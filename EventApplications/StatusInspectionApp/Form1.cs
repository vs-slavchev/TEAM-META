using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using MaterialSkin;
using CommonClasses;

namespace StatusInspectionApp
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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple700, Primary.Purple900,
                                            Primary.Purple400, Accent.Purple100, TextShade.WHITE);

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

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusController.VisitorsListBoxSelectedIndexChanged();
        }

        private void ListFreeCampSpots()
        {
            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                string query = String.Format(Queries.SELECT, "camp", "user_count", 0);
                reader = connection.ExecuteReaderQuery(query);
                while (reader.Read())
                {
                    liCampSpots.Items.Add(reader["camp_id"].ToString());
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void updateOverallStatus_Click(object sender, EventArgs e)
        {
            //clear labels and listbox
            StatusPanelController.ClearLabel(lbVisitorsEntered);
            StatusPanelController.ClearLabel(lbVisitorsNotEntered);
            StatusPanelController.ClearLabel(lbVisitorsLeft);
            StatusPanelController.ClearLabel(lbTotalBalance);
            StatusPanelController.ClearLabel(lbTotalMoneyPaid);
            StatusPanelController.ClearLabel(lbCampSpotsBooked);
            liCampSpots.Items.Clear();

            //get updated info
            connection.Open();
            int visitorsEntered = (int)connection.ExecuteScalar(
                    String.Format(Queries.SELECT_COUNT, "user", "has_entered"));
            int visitorsNotEntered = (int)connection.ExecuteScalar(
                    String.Format(Queries.SELECT_COUNT, "user", "NOT has_entered"));
            int visitorsLeft = (int)connection.ExecuteScalar(
                    String.Format(Queries.SELECT_COUNT, "user", "has_left"));
            double totalMoneyBalance = connection.ExecuteScalar(
                    String.Format(Queries.SELECT_SUM, "money", "user"));
            double totalMoneyPaid = connection.ExecuteScalar(
                    String.Format(Queries.SELECT_SUM, "total_money", "user"));
            totalMoneyPaid -= totalMoneyBalance;
            int numberCampSpotsBooked = (int)connection.ExecuteScalar(
                    String.Format(Queries.SELECT_COUNT, "camp", "user_count > 0"));
            connection.Close();

            //print updated info
            lbVisitorsEntered.Text = Convert.ToString(visitorsEntered);
            lbVisitorsNotEntered.Text = Convert.ToString(visitorsNotEntered);
            lbVisitorsLeft.Text = Convert.ToString(visitorsLeft);
            lbTotalBalance.Text = String.Format(Queries.MONEY_FORMAT, totalMoneyBalance);
            lbTotalMoneyPaid.Text = String.Format(Queries.MONEY_FORMAT, totalMoneyPaid);
            lbCampSpotsBooked.Text = Convert.ToString(numberCampSpotsBooked);

            //add list of free camp spots
            ListFreeCampSpots();
        }

        private void retrieveQRdata_Click(object sender, EventArgs e)
        {
            statusController.SelectUserFromQRReaderCode();
        }

        private void searchByLastName_Click(object sender, EventArgs e)
        {
            statusController.SearchByLastNameButtonClick();
        }

        private void clearResult_Click(object sender, EventArgs e)
        {
            statusController.ClearResultsButtonClick();
        }
    }
}
