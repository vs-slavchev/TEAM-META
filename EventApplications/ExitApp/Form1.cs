using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
using MySql.Data;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace ExitApp
{
    public partial class Form1 : MaterialForm
    {

        private DBConnection connection;
        private StatusPanelController statusController;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SkinColors.GetDefaultColor();

            connection = new DBConnection();
            statusController = new StatusPanelController(connection);

            statusController.RetrieveQRData = retrieveQRdata;
            statusController.SearchLastName = tbSearchLastname;
            statusController.SearchByLastNameButton = searchByLastName;
            statusController.Email = lbEmail;
            statusController.PhoneNumber = lbPhoneNumber;
            statusController.Money = lbMoney;
            statusController.HasEntered = lbHasEntered;
            statusController.HasLeft = lbHasLeft;
            statusController.MoneySpentOnFood = lbMoneySpentFood;
            statusController.TotalMoney = lbMoneyTransferred;
            statusController.Visitors = liVisitors;
            statusController.ClearResult = clearResult;
        }

        private void searchByLastName_Click(object sender, EventArgs e)
        {
            statusController.SearchByLastNameButtonClick();
        }

        private void retrieveQRdata_Click(object sender, EventArgs e)
        {
            Person visitor;
            visitor = statusController.SelectUserFromQRReaderCode();
            checkLoanedMaterials();
            if (visitor != null)
            {
                lb_moneyToReturn.Text = String.Format(Queries.MONEY_FORMAT, visitor.Money);
            }
        }

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusController.VisitorsListBoxSelectedIndexChanged();
        }

        private void clearResult_Click(object sender, EventArgs e)
        {
            statusController.ClearResultsButtonClick();
            lb_moneyToReturn.Text = String.Format(Queries.MONEY_FORMAT, 0);
        }

        public void checkLoanedMaterials()
        {
            listBox1.Items.Clear();
            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = connection.ExecuteReaderQuery(String.Format(Queries.RETURN_LOAN, statusController.UserQrCode));

                while (reader.Read())
                {
                    string materialName = reader["type"].ToString();
                    listBox1.Items.Add(materialName);
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void returnMoney_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("Visitor must return some loaned materials!");
                return;
            }

            try
            {
                connection.Open();
                connection.ExecuteNonQuery(String.Format(Queries.UPDATE_USER_LEFT, statusController.UserQrCode));

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }

            lb_moneyToReturn.Text = String.Format(Queries.MONEY_FORMAT, 0);
            MessageBox.Show("Successfully marked account as invalid.");
        }
    }
}
