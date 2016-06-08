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

namespace StatusInspectionApp
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

        private void btRetrieveQRData_Click(object sender, EventArgs e)
        {
            statusController.SelectUserFromQRReaderCode();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            statusController.SearchByLastNameButtonClick();
        }

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusController.VisitorsListBoxSelectedIndexChanged();
        }

        private void btClearResult_Click(object sender, EventArgs e)
        {
            statusController.ClearResultsButtonClick();
        }

        private void btUpdateOverallStatus_Click(object sender, EventArgs e)
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
            int visitorsEntered =
                (int)connection.ExecuteScalar(String.Format(Queries.SELECT_COUNT, "user", "has_entered"));
            int visitorsNotEntered =
                (int)connection.ExecuteScalar(String.Format(Queries.SELECT_COUNT, "user", "NOT has_entered"));
            int visitorsLeft =
                (int)connection.ExecuteScalar(String.Format(Queries.SELECT_COUNT, "user", "has_left"));
            double totalMoneyBalance =
                connection.ExecuteScalar(String.Format(Queries.SELECT_SUM, "money", "user"));
            double totalMoneyPaid =
                connection.ExecuteScalar(String.Format(Queries.SELECT_SUM, "total_money", "user"));
            totalMoneyPaid -= totalMoneyBalance;
            int numberCampSpotsBooked =
                (int)connection.ExecuteScalar(String.Format(Queries.SELECT_COUNT,"camp", "user_count > 0"));
            connection.Close();

            //print updated info
            lbVisitorsEntered.Text = Convert.ToString(visitorsEntered);
            lbVisitorsNotEntered.Text = Convert.ToString(visitorsNotEntered);
            lbVisitorsLeft.Text = Convert.ToString(visitorsLeft);
            lbTotalBalance.Text = String.Format(Queries.MONEY_FORMAT, totalMoneyBalance);
            lbTotalMoneyPaid.Text = String.Format(Queries.MONEY_FORMAT, totalMoneyPaid);
            lbCampSpotsBooked.Text = Convert.ToString(numberCampSpotsBooked);

            //add list of free camp spots
        }


    }
}
