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

namespace ShopApp
{
	public partial class Form1 : Form
	{
		private DBConnection connection;
		private string ShopId, PcId;
		private List<Products> pro;
		private int x = 1;
		private double total = 0;
		private Person per;
		
		public Form1()
		{
			InitializeComponent();
			connection = new DBConnection();

			ShopId = Prompt.ShowDialog("Enter Shop ID", "Shops");

			pro = new List<Products>();
			PcId = StatusPanelController.PromptForPcId();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				foreach (Products po in pro)
				{
					string queryString = String.Format(Queries.PURCHASE_INSERT,
									 per.QR_code, po.Id, ShopId, po.Quantity);
					connection.ExecuteNonQuery(queryString);
				}
					string queryString1 = String.Format(Queries.MONEY_UPDATE, total, per.QR_code);
					connection.ExecuteNonQuery(queryString1);
			}
			finally
			{
				connection.Close();
				connection.NullQRvalueInDB(PcId);
				listBox1.Items.Clear();
				numericUpDown1.Value = 1;
				lblTotal.Text = "0€";
				pro = new List<Products>();
			}
			
		}



		private void lblTotal_Click(object sender, EventArgs e)
		{

		}

		private void txtQty1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			total = 0;
			foreach (Products p in pro)
			{
				total += p.Price*p.Quantity;
			}
			lblTotal.Text = total.ToString() + "€";

			if (per.Money - total < 0)
			{
				lblTotal.Text = "Error !!!";
				MessageBox.Show("Not enough money in your account!!!");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11110, 3.50, "Hamburger",x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11111, 4.00, "Cheeseburger", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11112, 3.50, "Hot dog", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11113, 5.00, "Chicken wings", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11114, 3.00, "French fries", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11115, 6.00, "Chicken doner", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11116, 7.00, "Mixed doner", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11120, 0.50, "Ketchup", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11121, 0.50, "Mayo", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11122, 0.50, "Chili", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11123, 0.50, "Garlic sauce", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11130, 2.50, "Coca Cola", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11131, 2.50, "Fanta", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11132, 1.50, "Water", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11133, 3.00, "Beer", x);
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			int x;
			x = listBox1.SelectedIndex;
			pro.RemoveAt(x);
			listBox1.Items.Clear();
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			x = Convert.ToInt16(numericUpDown1.Value);
		}

		private void button19_Click(object sender, EventArgs e)
		{
			per = connection.GetPersonFromQRreader(PcId);
		}

	}
}
