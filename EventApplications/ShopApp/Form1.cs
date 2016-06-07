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
		private StatusPanelController statusController;
		string ShopId;
		private List<Products> pro;
		
		public Form1()
		{
			InitializeComponent();
			connection = new DBConnection();
			statusController = new StatusPanelController(connection);

			ShopId = Prompt.ShowDialog("Enter Shop ID", "Shops");

			pro = new List<Products>();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}



		private void lblTotal_Click(object sender, EventArgs e)
		{

		}

		private void txtQty1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double x = 0;
			foreach (Products p in pro)
			{
				x += p.Price;
			}
			lblTotal.Text = x.ToString() + "€";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11110, 3.50, "Hamburger");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11111, 4.00, "Cheeseburger");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11112, 3.50, "Hot dog");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11113, 5.00, "Chicken wings");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11114, 3.00, "French fries");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11115, 6.00, "Chicken doner");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11116, 7.00, "Mixed doner");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11120, 0.50, "Ketchup");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11121, 0.50, "Mayo");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11122, 0.50, "Chili");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11123, 0.50, "Garlic sauce");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11130, 2.50, "Coca Cola");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11131, 2.50, "Fanta");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11132, 1.50, "Water");
			pro.Add(p);
			foreach (Products a in pro)
			{
				listBox1.Items.Add(a.Info());
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			Products p = new Products(11133, 3.00, "Beer");
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
	}
}
