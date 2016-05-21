using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonClasses
{
    /*
     * The class controlls all the status inspection panels for
     * a single person. 
     */
    public class StatusPanelController
    {

        public Button RetrieveQRData { get; set; }
        public TextBox LastName { get; set; }
        public Button SearchByLastName { get; set; }
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
        private List<Person> visitors;

        public StatusPanelController(DBConnection connection)
        {
            this.connection = connection;
        }

        public void SearchByLastNameButtonClick()
        {
            if (LastName.Text != "")
            {
                visitors = connection.SelectVisitor("last_name", LastName.Text);
            }
            else
            {
                return;
            }

            LastName.Clear();
            ClearResultLabels();

            Visitors.Items.Clear();
            foreach (Person p in visitors){
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
        }

        private void ClearResultLabels()
        {
            Clear(Email);
            Clear(PhoneNumber);
            Clear(Money);
            Clear(HasEntered);
            Clear(HasLeft);
            Clear(MoneySpentOnFood);
            Clear(TotalMoney);
        }

        public static void Clear(Label lb)
        {
            lb.Text = "---";
        }
    }
}
