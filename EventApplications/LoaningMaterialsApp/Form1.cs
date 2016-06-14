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
using MaterialSkin.Controls;
using MaterialSkin;

namespace Loaning_materialsApp
{
    public partial class Form1 : MaterialForm
    {
        private DBConnection connection = new DBConnection();
        private List<Material> materials = new List<Material>();
        private Person visitor = null;
        private decimal totalRentProfit = 0;
        private string PcId;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple700, Primary.Purple900,
                                            Primary.Purple400, Accent.Purple100, TextShade.WHITE);

            listView2.FullRowSelect = true;
            PcId = StatusPanelController.PromptForPcId();
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

        private void loan_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView2.SelectedItems)
            {
                Material NewMat = new Material(selectedItem, visitor);

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[1].Text.Equals(NewMat.Name)
                        && item.SubItems[2].Text.Equals(NewMat.Renter))
                    {
                        MessageBox.Show("This visitor already has this item.");
                        return;
                    }
                }

                connection.Open();
                double visitor_money = connection.ExecuteScalar(String.Format("SELECT `money` FROM `user` WHERE `qr_code` = '{0}'", visitor.QR_code));
                if (Convert.ToDecimal(visitor_money) >= NewMat.Price)
                {
                    string insert = String.Format(Queries.INSERT_MATERIAL_LOAN, NewMat.Renter, NewMat.ID);
                    string insertpt2 = String.Format(Queries.INSERT_MATERIAL_LOAN_PT2, NewMat.Price, NewMat.Renter);
                    string update = String.Format(Queries.UPDATE_MATERIAL_QUANTITY, "-1", NewMat.ID);
                    connection.ExecuteNonQuery(insert);
                    connection.ExecuteNonQuery(insertpt2);
                    connection.ExecuteNonQuery(update);
                    AddToListView1(NewMat);
                    materials.Add(NewMat);
                }
                else { MessageBox.Show("This visitor doesn't have enough money."); }
                connection.Close();
            }
        }

        private void returnMaterial_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No material ID is entered!");
                return;
            }
            if (visitor == null)
            {
                MessageBox.Show("No user is currently selected!");
                return;
            }

            int matID;
            try
            {
                matID = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Material ID is not valid!");
                return;
            }

            for (int i = 0; i < materials.Count(); i++)
            {
                if ((matID == materials[i].ID) && (visitor.QR_code == materials[i].Renter))
                {
                    materials.RemoveAt(i);
                    connection.Open();
                    connection.ExecuteNonQuery(String.Format(Queries.DELETE_LOAN_MATERIAL, visitor.QR_code, matID));
                    connection.ExecuteNonQuery(String.Format(Queries.UPDATE_MATERIAL_QUANTITY, "+1", matID));
                    connection.Close();
                    break;
                }
            }
            UpdateListView1();
            CreateListView2();
        }

        private void retrieveQR_Click(object sender, EventArgs e)
        {
            visitor = connection.GetPersonFromQRreader(PcId);
            if (visitor == null)
            {
                return;
            }
            lb_visitorName.Text = visitor.Last_name;
        }

        private void clearUser_Click(object sender, EventArgs e)
        {
            if (visitor != null)
            {
                StatusPanelController.ClearLabel(lb_visitorName);
                visitor = null;
                connection.NullQRvalueInDB(PcId);
            }
        }
    }
}
