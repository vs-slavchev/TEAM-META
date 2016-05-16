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
                visitors = connection.ExecuteSelectVisitor("user_id", tbId.Text);
            }
            else if (tbLastname.Text != "")
            {
                visitors = connection.ExecuteSelectVisitor("last_name", tbLastname.Text);
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
            Clear(lbVisitorsEntered);
            Clear(lbVisitorsNotEntered);
            Clear(lbVisitorsLeft);
            Clear(lbTotalBalance);
            Clear(lbTotalMoneyPaid);
            Clear(lbCampSpotsBooked);
            liCampSpots.Items.Clear();

            //get updated info

            //print updated info
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
                //lbMoney =
                //lbHasEntered = 
                //lbMoneySpentFood = 
                //lbMoneyTransferred = 
            }
        }

        private void ClearResultLabels()
        {
            Clear(lbEmail);
            Clear(lbMoney);
            Clear(lbHasEntered);
            Clear(lbMoneySpentFood);
            Clear(lbMoneyTransferred);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
