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
        private List<Person> visitors;

        public Form1()
        {
            InitializeComponent();
            connection = new DBConnection();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "")
            {
                visitors = connection.SelectVisitor("user_id", tbId.Text);
            }
            else if (tbLastname.Text != "")
            {
                visitors = connection.SelectVisitor("last_name", tbLastname.Text);
            }
            else
            {
                return;
            }

            tbId.Clear();
            tbLastname.Clear();
            ClearResultLabels();

            liVisitors.Items.Clear();
            foreach (Person p in visitors){
                liVisitors.Items.Add(p);
            }
        }

        private void btUpdateOverallStatus_Click(object sender, EventArgs e)
        {
            //clear lablels and listbox
            Clear(lbVisitorsEntered);
            Clear(lbVisitorsNotEntered);
            Clear(lbVisitorsLeft);
            Clear(lbTotalBalance);
            Clear(lbTotalMoneyPaid);
            Clear(lbCampSpotsBooked);
            liCampSpots.Items.Clear();

            //get updated info
            int visitorsEntered = connection.ScalarCount("has_entered", "user");
            int visitorsNotEntered = connection.ScalarCount("NOT has_entered", "user");
            int visitorsLeft = connection.ScalarCount("has_left", "user");
            double totalMoneyBalance = connection.ScalarSum("money", "user");
            double totalMoneyPaid = connection.ScalarSum("total_money", "user") - totalMoneyBalance;
            //int numberCampSpotsBooked = connection.ScalarSum("total_money", "camp");

            //print updated info
            lbVisitorsEntered.Text = Convert.ToString(visitorsEntered);
            lbVisitorsNotEntered.Text = Convert.ToString(visitorsNotEntered);
            lbVisitorsLeft.Text = Convert.ToString(visitorsLeft);
            lbTotalBalance.Text = Convert.ToString(totalMoneyBalance);
            lbTotalMoneyPaid.Text = Convert.ToString(totalMoneyPaid);
            //lbCampSpotsBooked.Text = Convert.ToString();

        }

        private void btClearResult_Click(object sender, EventArgs e)
        {
            ClearResultLabels();
            liVisitors.Items.Clear();
        }

        private void Clear(Label lb)
        {
            lb.Text = "---";
        }

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person visitor;
            if (liVisitors.SelectedItem is Person)
            {
                visitor = (Person)(liVisitors.SelectedItem);

                ClearResultLabels();
                lbEmail.Text = visitor.Email;
                lbPhoneNumber.Text = visitor.Phone_number;
                lbMoney.Text = Convert.ToString(visitor.Money);
                lbHasEntered.Text = visitor.HasEntered.ToString();
                lbHasLeft.Text = visitor.HasLeft.ToString();
                //lbMoneySpentFood.Text = 
                //lbMoneyTransferred.Text = 
            }
        }

        private void ClearResultLabels()
        {
            Clear(lbEmail);
            Clear(lbPhoneNumber);
            Clear(lbMoney);
            Clear(lbHasEntered);
            Clear(lbHasLeft);
            Clear(lbMoneySpentFood);
            Clear(lbMoneyTransferred);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
