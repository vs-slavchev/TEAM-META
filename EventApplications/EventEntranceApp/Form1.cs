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

namespace EventEntranceApp
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

            if (!(statusController.Visitors.SelectedItem is Person))
            {
                return;
            }

            AllowedToEnterReasonsPrint((Person)statusController.Visitors.SelectedItem);
        }

        private void AllowedToEnterReasonsPrint(Person visitor)
        {
            bool allowedToEnter = true;
            if (visitor.MoneyOwed > 0.00)
            {
                liReasons.Items.Add("Not all fees have been paid.");
                allowedToEnter = false;
            }
            if (visitor.HasLeft)
            {
                liReasons.Items.Add("Visitor has already left.");
                allowedToEnter = false;
            }
            if (visitor.First_name.Equals("") || visitor.Last_name.Equals(""))
            {
                liReasons.Items.Add("Not all information about visitor was supplied.");
                allowedToEnter = false;
            }

            lbAllowedToEnter.Text = allowedToEnter ? "YES" : "NO";
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
            liReasons.Items.Clear();
            lbAllowedToEnter.Text = "--";
        }

        private void btInsertInfo_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phoneNumber = tbPhoneNumber.Text;
            string paypal = tbPaypal.Text;

            if (email.Equals("") || lastName.Equals("") || paypal.Equals(""))
            {
                MessageBox.Show("Required info is not input!", "Warning");
                return;
            }

            string queryString = String.Format(Queries.USER_INSERT,
                                 email, firstName, lastName, phoneNumber, paypal);
            connection.Open();
            connection.ExecuteNonQuery(queryString);
            connection.Close();

            ClearInsertFields();
            MessageBox.Show("User successfuly added.", "Success");
        }

        private void btClearFields_Click(object sender, EventArgs e)
        {
            ClearInsertFields();
        }

        private void btMarkAsEntered_Click(object sender, EventArgs e)
        {
            if (statusController.UserIdFromQRreader.Equals(""))
            {
                MessageBox.Show("No user is currently selected.", "Warning");
                return;
            }
            string queryString = String.Format(Queries.USER_UPDATE,
                                 "has_entered", "true", statusController.UserIdFromQRreader);

            connection.Open();
            connection.ExecuteNonQuery(queryString);
            connection.Close();
        }

        private void ClearInsertFields()
        {
            tbEmail.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbPhoneNumber.Clear();
            tbPaypal.Clear();
        }

    }
}
