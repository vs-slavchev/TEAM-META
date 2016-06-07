using CommonClasses;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loaning_materialsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBConnection conn = new DBConnection();
        List<Material> mats = new List<Material>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Restore();
            CreateListView2();
        }

        private void Restore()
        {
            conn.Open();
            MySqlDataReader datareader = conn.ExecuteReaderQuery("SELECT material.material_id, material.Type, material_loan.user_qr, material.rent_price FROM `material` INNER JOIN `material_loan` ON material.material_id=material_loan.material_id");
            while (datareader.Read())
            {
                Material NewMat = new Material();
                NewMat.ID = datareader.GetInt32("material_id");
                NewMat.Name = datareader.GetString("Type");
                NewMat.Price = datareader.GetDecimal("rent_price");
                NewMat.Renter = datareader.GetString("user_qr");
                totalrentprofit += NewMat.Price;
                mats.Add(NewMat);
            }
            conn.Close();
            UpdateListView1();
        }

        private void UpdateListView1()
        {
            listView1.Items.Clear();
            foreach (Material mat in mats)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(mat.Name);
                lvi.SubItems.Add(Convert.ToString(mat.Renter));
                lvi.SubItems.Add(Convert.ToString(mat.Price));
                listView1.Items.Add(lvi);
            }
            textBox2.Text = "Total: " + Convert.ToString(totalrentprofit);
        }

        private decimal totalrentprofit = 0;
        private void AddToListView1(Material mat)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(mat.Name);
            lvi.SubItems.Add(Convert.ToString(mat.Renter));
            lvi.SubItems.Add(Convert.ToString(mat.Price));
            listView1.Items.Add(lvi);
            totalrentprofit += mat.Price;
            textBox2.Text = "Total: " + Convert.ToString(totalrentprofit);
        }

        private void CreateListView2()
        {
            listView2.Items.Clear();
            conn.Open();
            MySqlDataReader datareader = conn.ExecuteReaderQuery("SELECT * FROM `material`");
            while (datareader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(datareader.GetString("material_id"));
                lvi.SubItems.Add(datareader.GetString("type"));
                lvi.SubItems.Add(datareader.GetString("rent_price"));
                lvi.SubItems.Add(datareader.GetString("quantity_left"));
                listView2.Items.Add(lvi);
            }
            conn.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string r = Prompt.ShowDialog("Client ID:", "ID");
            Material NewMat = new Material();
            NewMat.ID = Convert.ToInt32(listView2.Items[0].SubItems[1].Text);
            NewMat.Name = listView2.Items[0].SubItems[2].Text;
            NewMat.Price = Convert.ToDecimal(listView2.Items[0].SubItems[3].Text);
            NewMat.Renter = r;
            listView2.Items[0].SubItems[4].Text = Convert.ToString(Convert.ToInt32(listView2.Items[0].SubItems[4].Text)-1);
            conn.Open();
            conn.ExecuteNonQuery(String.Format("INSERT INTO `material_loan`(`user_qr`, `material_id`) VALUES({0}, {1})", NewMat.Renter, NewMat.ID));
            conn.ExecuteNonQuery(String.Format("UPDATE `material` SET `quantity_left`=`quantity_left` - 1 WHERE `material_id` = {0}", NewMat.ID));
            conn.Close();
            AddToListView1(NewMat);
            mats.Add(NewMat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r = Prompt.ShowDialog("Client ID:", "ID");
            Material NewMat = new Material();
            NewMat.ID = Convert.ToInt32(listView2.Items[1].SubItems[1].Text);
            NewMat.Name = listView2.Items[1].SubItems[2].Text;
            NewMat.Price = Convert.ToDecimal(listView2.Items[1].SubItems[3].Text);
            NewMat.Renter = r;
            listView2.Items[1].SubItems[4].Text = Convert.ToString(Convert.ToInt32(listView2.Items[1].SubItems[4].Text) - 1);
            conn.Open();
            conn.ExecuteNonQuery(String.Format("INSERT INTO `material_loan`(`user_qr`, `material_id`) VALUES({0}, {1})", NewMat.Renter, NewMat.ID));
            conn.ExecuteNonQuery(String.Format("UPDATE `material` SET `quantity_left`=`quantity_left` - 1 WHERE `material_id` = {0}", NewMat.ID));
            conn.Close();
            AddToListView1(NewMat);
            mats.Add(NewMat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r = Prompt.ShowDialog("Client ID:", "ID");
            Material NewMat = new Material();
            NewMat.ID = Convert.ToInt32(listView2.Items[2].SubItems[1].Text);
            NewMat.Name = listView2.Items[2].SubItems[2].Text;
            NewMat.Price = Convert.ToDecimal(listView2.Items[2].SubItems[3].Text);
            NewMat.Renter = r;
            listView2.Items[2].SubItems[4].Text = Convert.ToString(Convert.ToInt32(listView2.Items[2].SubItems[4].Text) - 1);
            conn.Open();
            conn.ExecuteNonQuery(String.Format("INSERT INTO `material_loan`(`user_qr`, `material_id`) VALUES({0}, {1})", NewMat.Renter, NewMat.ID));
            conn.ExecuteNonQuery(String.Format("UPDATE `material` SET `quantity_left`=`quantity_left` - 1 WHERE `material_id` = {0}", NewMat.ID));
            conn.Close();
            AddToListView1(NewMat);
            mats.Add(NewMat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r = Prompt.ShowDialog("Client ID:", "ID");
            Material NewMat = new Material();
            NewMat.ID = Convert.ToInt32(listView2.Items[3].SubItems[1].Text);
            NewMat.Name = listView2.Items[3].SubItems[2].Text;
            NewMat.Price = Convert.ToDecimal(listView2.Items[3].SubItems[3].Text);
            NewMat.Renter = r;
            listView2.Items[3].SubItems[4].Text = Convert.ToString(Convert.ToInt32(listView2.Items[3].SubItems[4].Text) - 1);
            conn.Open();
            conn.ExecuteNonQuery(String.Format("INSERT INTO `material_loan`(`user_qr`, `material_id`) VALUES({0}, {1})", NewMat.Renter, NewMat.ID));
            conn.ExecuteNonQuery(String.Format("UPDATE `material` SET `quantity_left`=`quantity_left` - 1 WHERE `material_id` = {0}", NewMat.ID));
            conn.Close();
            AddToListView1(NewMat);
            mats.Add(NewMat);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string r = Prompt.ShowDialog("Client ID:", "ID");
            Material NewMat = new Material();
            NewMat.ID = Convert.ToInt32(listView2.Items[4].SubItems[1].Text);
            NewMat.Name = listView2.Items[4].SubItems[2].Text;
            NewMat.Price = Convert.ToDecimal(listView2.Items[4].SubItems[3].Text);
            NewMat.Renter = r;
            listView2.Items[4].SubItems[4].Text = Convert.ToString(Convert.ToInt32(listView2.Items[4].SubItems[4].Text) - 1);
            conn.Open();
            conn.ExecuteNonQuery(String.Format("INSERT INTO `material_loan`(`user_qr`, `material_id`) VALUES({0}, {1})", NewMat.Renter, NewMat.ID));
            conn.ExecuteNonQuery(String.Format("UPDATE `material` SET `quantity_left`=`quantity_left` - 1 WHERE `material_id` = {0}", NewMat.ID));
            conn.Close();
            AddToListView1(NewMat);
            mats.Add(NewMat);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int matID = Convert.ToInt32(textBox1.Text);
            string userID = textBox3.Text;
            for (int i = 0; i<mats.Count(); i++)
            {
                if((matID == mats[i].ID) && (userID == mats[i].Renter)) { mats.RemoveAt(i); break; }
            }
            conn.Open();
            conn.ExecuteNonQuery(String.Format("DELETE FROM `material_loan` WHERE `user_qr`={0} AND `material_id`={1}", userID, matID));
            conn.ExecuteNonQuery(String.Format("UPDATE `material` SET `quantity_left`=`quantity_left` + 1 WHERE `material_id` = {0}", matID));
            conn.Close();
            UpdateListView1();
            CreateListView2();
        }
    }
}
