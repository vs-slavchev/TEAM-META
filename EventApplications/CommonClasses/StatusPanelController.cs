using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CommonClasses
{
    /*
     * Controlls all the status inspection panels for
     * a single person. 
     */
    public class StatusPanelController
    {

        public Button RetrieveQRData { get; set; }
        public TextBox SearchLastName { get; set; }
        public Button SearchByLastNameButton { get; set; }
        public Label Email { get; set; }
        public Label PhoneNumber { get; set; }
        public Label Money { get; set; }
        public Label HasEntered { get; set; }
        public Label HasLeft { get; set; }
        public Label MoneySpentOnFood { get; set; }
        public Label TotalMoney { get; set; }
        public ListBox Visitors { get; set; }
        public Button ClearResult { get; set; }
        private string moneyStringFormat = "{0:0.00} €";

        public string UserIdFromQRreader { get; private set; }

        private DBConnection connection;
        private string PcId;

        public StatusPanelController(DBConnection connection)
        {
            this.connection = connection;
        }

        public void RetrieveQRcodeFromReader()
        {
            ClearResultsAndVisitors();

            MySqlDataReader readerUser = null, readerForDevice = null;
            try
            {
                connection.Open();
                readerForDevice = connection.ReaderQuery("device_id = '" + PcId + "'", "reader_device");
                while (readerForDevice.Read())
                {
                    UserIdFromQRreader = readerForDevice["qr_value"].ToString();
                }

                readerUser = connection.ReaderQuery("user_id = '" + UserIdFromQRreader + "'", "user");
                while (readerUser.Read())
                {
                    Visitors.Items.Add(new Person(readerUser));
                    Visitors.SelectedIndex = 0;
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (readerForDevice != null)
                {
                    readerForDevice.Close();
                }
                if (readerUser != null)
                {
                    readerUser.Close();
                }
            }
        }

        public void SearchByLastNameButtonClick()
        {
            ClearResultsAndVisitors();

            if (SearchLastName.Text.Equals(""))
            {
                return;
            }

            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = connection.ReaderQuery("last_name = '" + SearchLastName.Text + "'", "user");
                while (reader.Read())
                {
                    Visitors.Items.Add(new Person(reader));
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

            SearchLastName.Clear();
        }

        public void VisitorsListBoxSelectedIndexChanged()
        {
            Person visitor;
            if (Visitors.SelectedItem is Person)
            {
                visitor = (Person)(Visitors.SelectedItem);

                ClearResultLabels();
                Email.Text = visitor.Email;
                PhoneNumber.Text = visitor.Phone_number;
                Money.Text = String.Format(moneyStringFormat, visitor.Money);
                HasEntered.Text = visitor.HasEntered.ToString();
                HasLeft.Text = visitor.HasLeft.ToString();
                //MoneySpentOnFood.Text = String.Format(moneyStringFormat, complex query);
                TotalMoney.Text = String.Format(moneyStringFormat, visitor.TotalMoney);
            }
        }

        public void ClearResultsButtonClick()
        {
            ClearResultsAndVisitors();
        }

        public void ClearResultsAndVisitors()
        {
            ClearResultLabels();
            Visitors.Items.Clear();
        }

        private void ClearResultLabels()
        {
            ClearLabel(Email);
            ClearLabel(PhoneNumber);
            ClearLabel(Money);
            ClearLabel(HasEntered);
            ClearLabel(HasLeft);
            ClearLabel(MoneySpentOnFood);
            ClearLabel(TotalMoney);
        }

        public static void ClearLabel(Label lb)
        {
            lb.Text = "---";
        }
    }
}
