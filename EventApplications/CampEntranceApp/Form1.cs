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

namespace CampEntranceApp
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
    }
}
