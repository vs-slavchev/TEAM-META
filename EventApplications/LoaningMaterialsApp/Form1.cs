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
        private DBConnection connection = new DBConnection();
        private List<Material> materials = new List<Material>();
        private decimal totalRentProfit = 0;
        private Person visitor = null;
        private string PcId;

        public Form1()
        {
            InitializeComponent();
            listView2.FullRowSelect = true;
            PcId = Prompt.ShowDialog("Enter PC ID", "Device setup");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restore();
            CreateListView2();
        }

        private void Restore()
        {
            connection.Open();
            MySqlDataReader datareader = connection.ExecuteReaderQuery(
                    "SELECT material.material_id, material.type, "
                  + "material_loan.user_qr, material.rent_price "
                  + "FROM `material` INNER JOIN `material_loan` "
                  + "ON material.material_id=material_loan.material_id");

            while (datareader.Read())
            {
                Material NewMat = new Material(datareader);
                totalRentProfit += NewMat.Price;
                materials.Add(NewMat);
            }
            connection.Close();
            UpdateListView1();
        }

        private void UpdateListView1()
        {
            listView1.Items.Clear();
            foreach (Material mat in materials)
            {
                listView1.Items.Add(CreateListViewItem(mat));
            }
            textBox2.Text = Convert.ToString(totalRentProfit);
        }

        private void AddToListView1(Material mat)
        {
            listView1.Items.Add(CreateListViewItem(mat));
            totalRentProfit += mat.Price;
            textBox2.Text = Convert.ToString(totalRentProfit);
        }

        private ListViewItem CreateListViewItem(Material material)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems.Add(material.Name);
            listViewItem.SubItems.Add(Convert.ToString(material.Renter));
            listViewItem.SubItems.Add(Convert.ToString(material.Price));
            return listViewItem;
        }

        private void CreateListView2()
        {
            listView2.Items.Clear();
            connection.Open();
            MySqlDataReader datareader = connection.ExecuteReaderQuery("SELECT * FROM `material`");
            while (datareader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(datareader.GetString("material_id"));
                lvi.SubItems.Add(datareader.GetString("type"));
                lvi.SubItems.Add(datareader.GetString("rent_price"));
                lvi.SubItems.Add(datareader.GetString("quantity_left"));
                listView2.Items.Add(lvi);
            }
            connection.Close();
        }
        
        // loan material
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView2.SelectedItems)
            {
                Material NewMat = new Material(selectedItem, visitor);
                connection.Open();
                string insert = String.Format(Queries.INSERT_MATERIAL_LOAN, NewMat.Renter, NewMat.ID);
                string update = String.Format(Queries.UPDATE_MATERIAL_QUANTITY, "-1", NewMat.ID);
                connection.ExecuteNonQuery(insert);
                connection.ExecuteNonQuery(update);
                connection.Close();
                AddToListView1(NewMat);
                materials.Add(NewMat);
            }
        }

        //return material
        private void button6_Click(object sender, EventArgs e)
        {
            int matID = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < materials.Count(); i++)
            {
                if ((matID == materials[i].ID) && (visitor.QR_code == materials[i].Renter))
                {
                    materials.RemoveAt(i);
                    break;
                }
            }
            connection.Open();
            connection.ExecuteNonQuery(String.Format(Queries.DELETE_LOAN_MATERIAL, visitor.QR_code, matID));
            connection.ExecuteNonQuery(String.Format(Queries.UPDATE_MATERIAL_QUANTITY, "+1", matID));
            connection.Close();
            UpdateListView1();
            CreateListView2();
        }

        private void bt_retrieveQR_Click(object sender, EventArgs e)
        {
            visitor = connection.GetPersonFromQRreader(PcId);
            lb_visitorName.Text = visitor.Last_name;
        }

        private void bt_clearUser_Click(object sender, EventArgs e)
        {
            lb_visitorName.Text = "---";
            connection.NullQRvalueInDB(PcId);
        }
    }
}
