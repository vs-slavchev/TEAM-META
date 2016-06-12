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

namespace ExitApp
{
    public partial class Form1 : Form
    {

        private DBConnection connection;
        private StatusPanelController statusController;

        public Form1()
        {
            InitializeComponent();

            connection = new DBConnection();
            statusController = new StatusPanelController(connection);

            statusController.RetrieveQRData = btRetrieveQRData;
            statusController.SearchLastName = tbSearchLastname;
            statusController.SearchByLastNameButton = btSearch;
            statusController.Email = lbEmail;
            statusController.PhoneNumber = lbPhoneNumber;
            statusController.Money = lbMoney;
            statusController.HasEntered = lbHasEntered;
            statusController.HasLeft = lbHasLeft;
            statusController.MoneySpentOnFood = lbMoneySpentFood;
            statusController.TotalMoney = lbMoneyTransferred;
            statusController.Visitors = liVisitors;
            statusController.ClearResult = btClearResult;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            statusController.SearchByLastNameButtonClick();
        }

        private void btRetrieveQRData_Click(object sender, EventArgs e)
        {
            statusController.SelectUserFromQRReaderCode();
        }

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusController.VisitorsListBoxSelectedIndexChanged();
        }

        private void btClearResult_Click(object sender, EventArgs e)
        {
            statusController.ClearResultsButtonClick();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = connection.ExecuteReaderQuery(String.Format(Queries.RETURN_LOAN, statusController.UserQrCode));

                while (reader.Read())
                {
                    string materialID = reader["material_id"].ToString();
                    string materialName = reader["type"].ToString();
                    listBox1.Items.Add(materialName + " - " + materialID);
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

        private void btnReturnMoney_Click(object sender, EventArgs e)
        {
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
        }
    }
}
