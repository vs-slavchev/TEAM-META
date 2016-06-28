using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MaterialSkin.Controls;
using MaterialSkin;
using CommonClasses;

namespace EventEntranceApp
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

        private void retrieveQRdata_Click(object sender, EventArgs e)
        {
            statusController.SelectUserFromQRReaderCode();

            if (!(statusController.Visitors.SelectedItem is Person))
            {
                return;
            }

            AllowedToEnterReasonsPrint((Person)statusController.Visitors.SelectedItem);
        }

        private void searchByLastName_Click(object sender, EventArgs e)
        {
            statusController.SearchByLastNameButtonClick();
        }

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusController.VisitorsListBoxSelectedIndexChanged();
        }

        private void clearResult_Click(object sender, EventArgs e)
        {
            statusController.ClearResultsButtonClick();
            liReasons.Items.Clear();
            lbAllowedToEnter.Text = "--";
        }

        private void insertInfo_Click(object sender, EventArgs e)
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
            string qr_code = GetPost(email);
            if (qr_code.Equals(string.Empty))
            {
                MessageBox.Show("Could not generate a QR code.", "Failure");
                return;
            }
            string queryString = String.Format(Queries.USER_INSERT,
                                 email, firstName, lastName, phoneNumber, paypal, qr_code);
            connection.Open();
            connection.ExecuteNonQuery(queryString);
            connection.Close();

            ClearInsertFields();
            MessageBox.Show("User successfuly added.", "Success");
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            ClearInsertFields();
        }

        private void markAsEntered_Click(object sender, EventArgs e)
        {
            if (statusController.UserQrCode.Equals(""))
            {
                MessageBox.Show("No user is currently selected.", "Warning");
                return;
            }
            else if (lbAllowedToEnter.Text.Equals("NO"))
            {
                MessageBox.Show("This visitor is not allowed to enter!", "Warning");
                return;
            }
            string queryString = String.Format(Queries.USER_UPDATE,
                                 "has_entered", "true", statusController.UserQrCode);

            connection.Open();
            connection.ExecuteNonQuery(queryString);
            connection.Close();

            MessageBox.Show("Visitor successfully marked as entered!");
        }

        private void AllowedToEnterReasonsPrint(Person visitor)
        {
            liReasons.Items.Clear();
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

        private void ClearInsertFields()
        {
            tbEmail.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbPhoneNumber.Clear();
            tbPaypal.Clear();
        }

        /* Send the email field by http to the php file that is responsible
         * for calculating the hash of the email. This is done to reduce
         * duplication of code. */
        public static string GetPost(string value)
        {
            string URI = "http://athena.fhict.nl/users/i345959/php/email_hasher.php";

            string myParameters = "email=" + value;

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);
                return HtmlResult;
            }
        }
    }
}
