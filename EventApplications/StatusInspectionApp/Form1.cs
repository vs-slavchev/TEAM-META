using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusInspectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btClearResult_Click(object sender, EventArgs e)
        {
            Clear(lbEmail);
            Clear(lbMoney);
            Clear(lbHasEntered);
            Clear(lbMoneySpent);
            Clear(lbMoneyTransferred);
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


        }

        private void Clear(Label lb)
        {
            lb.Text = "---";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

    }
}
