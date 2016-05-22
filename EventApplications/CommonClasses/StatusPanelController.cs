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
     * The class controlls all the status inspection panels for
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

        private DBConnection connection;
        private List<Person> visitors = new List<Person>();

        public StatusPanelController(DBConnection connection)
        {
            this.connection = connection;
        }

        public void SearchByLastNameButtonClick()
        {
            ClearResultLabels();
            Visitors.Items.Clear();
            visitors.Clear();

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
                    visitors.Add(new Person(reader));
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
            ClearResultLabels();

            Visitors.Items.Clear();
            foreach (Person p in visitors)
            {
                Visitors.Items.Add(p);
            }
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
                Money.Text = Convert.ToString(visitor.Money);
                HasEntered.Text = visitor.HasEntered.ToString();
                HasLeft.Text = visitor.HasLeft.ToString();
                //MoneySpentOnFood.Text = 
                TotalMoney.Text = visitor.TotalMoney.ToString();
            }
        }

        public void ClearResultsButtonClick()
        {
            ClearResultLabels();
            Visitors.Items.Clear();
            visitors.Clear();
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
