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
            //clear lablels and listbox
            StatusPanelController.Clear(lbVisitorsEntered);
            StatusPanelController.Clear(lbVisitorsNotEntered);
            StatusPanelController.Clear(lbVisitorsLeft);
            StatusPanelController.Clear(lbTotalBalance);
            StatusPanelController.Clear(lbTotalMoneyPaid);
            StatusPanelController.Clear(lbCampSpotsBooked);
            liCampSpots.Items.Clear();

            //get updated info
            connection.Open();
            int visitorsEntered = connection.ScalarCount("has_entered", "user");
            int visitorsNotEntered = connection.ScalarCount("NOT has_entered", "user");
            int visitorsLeft = connection.ScalarCount("has_left", "user");
            double totalMoneyBalance = connection.ScalarSum("money", "user");
            double totalMoneyPaid = connection.ScalarSum("total_money", "user") - totalMoneyBalance;
            //int numberCampSpotsBooked = connection.ScalarCount("is_booked", "camp");
            connection.Close();

            //print updated info
            lbVisitorsEntered.Text = Convert.ToString(visitorsEntered);
            lbVisitorsNotEntered.Text = Convert.ToString(visitorsNotEntered);
            lbVisitorsLeft.Text = Convert.ToString(visitorsLeft);
            lbTotalBalance.Text = Convert.ToString(totalMoneyBalance);
            lbTotalMoneyPaid.Text = Convert.ToString(totalMoneyPaid);
            //lbCampSpotsBooked.Text = Convert.ToString(numberCampSpotsBooked);
        }


    }
}
