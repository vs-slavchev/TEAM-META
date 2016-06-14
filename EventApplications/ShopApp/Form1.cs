using CommonClasses;
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

namespace ShopApp
{
    public partial class Form1 : MaterialForm
	{
		private DBConnection connection;
		private string ShopId, PcId;
		private List<Product> products;
		private int quantity = 1;
		private double total = 0;
		private Person person;
		
		public Form1()
		{
			InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple700, Primary.Purple900,
                                            Primary.Purple400, Accent.Purple100, TextShade.WHITE);

			connection = new DBConnection();
			products = new List<Product>();

            ShopId = PromptForShopId();
			PcId = StatusPanelController.PromptForPcId();
		}

        private void buy_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				foreach (Product po in products)
				{
					string queryString = String.Format(Queries.PURCHASE_INSERT,
									 person.QR_code, po.Id, ShopId, po.Quantity);
					connection.ExecuteNonQuery(queryString);
				}
				string queryString1 = String.Format(Queries.MONEY_UPDATE, total, person.QR_code);
				connection.ExecuteNonQuery(queryString1);
			}
			finally
			{
				connection.Close();
				connection.NullQRvalueInDB(PcId);
				listBox1.Items.Clear();
				numericUpDown1.Value = 1;
				lblTotal.Text = "0.00 €";
				products = new List<Product>();
			}
		}

        private void sumTotal_Click(object sender, EventArgs e)
		{
			total = 0;
			foreach (Product p in products)
			{
				total += p.Price*p.Quantity;
			}
			lblTotal.Text = String.Format(Queries.MONEY_FORMAT, total.ToString());

			if (person.Money - total < 0)
			{
				lblTotal.Text = "Error !!!";
				MessageBox.Show("Not enough money in your account!!!");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11110, 3.50, "Hamburger",quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11111, 4.00, "Cheeseburger", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11112, 3.50, "Hot dog", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11113, 5.00, "Chicken wings", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11114, 3.00, "French fries", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11115, 6.00, "Chicken doner", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11116, 7.00, "Mixed doner", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11120, 0.50, "Ketchup", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11121, 0.50, "Mayo", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11122, 0.50, "Chili", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11123, 0.50, "Garlic sauce", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11130, 2.50, "Coca Cola", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11131, 2.50, "Fanta", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11132, 1.50, "Water", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Product p = new Product(11133, 3.00, "Beer", quantity);
			products.Add(p);
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

        private void remove_Click(object sender, EventArgs e)
		{
			products.RemoveAt(listBox1.SelectedIndex);
			listBox1.Items.Clear();
			foreach (Product a in products)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			quantity = Convert.ToInt16(numericUpDown1.Value);
		}

        private void retrieveQR_Click(object sender, EventArgs e)
		{
			person = connection.GetPersonFromQRreader(PcId);
            if (person == null)
            {
                return;
            }
            lb_visitorName.Text = person.Last_name;
		}

        private string PromptForShopId()
        {
            string shop_id = Prompt.ShowDialog("Enter Shop ID", "Shops");
            int id;
            try
            {
                id = Convert.ToInt32(shop_id);
            }
            catch (Exception)
            {
                MessageBox.Show("The shop ID is not valid!");
                return PromptForShopId();
            }
            if (id <= 0 || id >= 100)
            {
                MessageBox.Show("The shop ID is not in the valid range!");
                return PromptForShopId();
            }
            return shop_id;
        }
	}
}
