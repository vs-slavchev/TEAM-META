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
		
		public Form1()
		{
			InitializeComponent();
			connection = new DBConnection();
			statusController = new StatusPanelController(connection);

			ShopId = Prompt.ShowDialog("Enter Shop ID", "Shops");

			comboBoxName1.SelectedIndex = 0;
			comboBoxName2.SelectedIndex = 1;
			comboBoxName3.SelectedIndex = 2;
			comboBoxName4.SelectedIndex = 3;
			comboBoxName5.SelectedIndex = 4;
			comboBoxName6.SelectedIndex = 5;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxName2_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = this.comboBoxName2.GetItemText(this.comboBoxName2.SelectedItem);
			switch (s)
			{
				case "Hamburger":
					lblid2.Text = "11110";
					lblPrice2.Text = "3.50";
					break;
				case "Cheeseburger":
					lblid2.Text = "11111";
					lblPrice2.Text = "4.00";
					break;
				case "Hot dog":
					lblid2.Text = "11112";
					lblPrice2.Text = "3.50";
					break;
				case "Chicken wings":
					lblid2.Text = "11113";
					lblPrice2.Text = "5.00";
					break;
				case "French fries":
					lblid2.Text = "11114";
					lblPrice2.Text = "3.00";
					break;
				case "Chicken doner":
					lblid2.Text = "11115";
					lblPrice2.Text = "6.00";
					break;
				case "Mixed doner":
					lblid2.Text = "11116";
					lblPrice2.Text = "7.00";
					break;
				case "Ketchup":
					lblid2.Text = "11120";
					lblPrice2.Text = "0.50";
					break;
				case "Mayo":
					lblid2.Text = "11121";
					lblPrice2.Text = "0.50";
					break;
				case "Chili":
					lblid2.Text = "11122";
					lblPrice2.Text = "0.50";
					break;
				case "Garlic sauce":
					lblid2.Text = "11123";
					lblPrice2.Text = "0.50";
					break;
				case "Coca Cola":
					lblid2.Text = "11130";
					lblPrice2.Text = "2.50";
					break;
				case "Fanta":
					lblid2.Text = "11131";
					lblPrice2.Text = "2.50";
					break;
				case "Water":
					lblid2.Text = "11132";
					lblPrice2.Text = "1.50";
					break;
				case "Beer":
					lblid2.Text = "11133";
					lblPrice2.Text = "3.00";
					break;

			}


		}

		private void lblTotal_Click(object sender, EventArgs e)
		{

		}

		private void txtQty1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void comboBoxName1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = this.comboBoxName1.GetItemText(this.comboBoxName1.SelectedItem);
			switch (s)
			{
				case "Hamburger":
					lblid1.Text = "11110";
					lblPrice1.Text = "3.50";
					break;
				case "Cheeseburger":
					lblid1.Text = "11111";
					lblPrice1.Text = "4.00";
					break;
				case "Hot dog":
					lblid1.Text = "11112";
					lblPrice1.Text = "3.50";
					break;
				case "Chicken wings":
					lblid1.Text = "11113";
					lblPrice1.Text = "5.00";
					break;
				case "French fries":
					lblid1.Text = "11114";
					lblPrice1.Text = "3.00";
					break;
				case "Chicken doner":
					lblid1.Text = "11115";
					lblPrice1.Text = "6.00";
					break;
				case "Mixed doner":
					lblid1.Text = "11116";
					lblPrice1.Text = "7.00";
					break;
				case "Ketchup":
					lblid1.Text = "11120";
					lblPrice1.Text = "0.50";
					break;
				case "Mayo":
					lblid1.Text = "11121";
					lblPrice1.Text = "0.50";
					break;
				case "Chili":
					lblid1.Text = "11122";
					lblPrice1.Text = "0.50";
					break;
				case "Garlic sauce":
					lblid1.Text = "11123";
					lblPrice1.Text = "0.50";
					break;
				case "Coca Cola":
					lblid1.Text = "11130";
					lblPrice1.Text = "2.50";
					break;
				case "Fanta":
					lblid1.Text = "11131";
					lblPrice1.Text = "2.50";
					break;
				case "Water":
					lblid1.Text = "11132";
					lblPrice1.Text = "1.50";
					break;
				case "Beer":
					lblid1.Text = "11133";
					lblPrice1.Text = "3.00";
					break;

			}


		}

		private void comboBoxName3_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = this.comboBoxName3.GetItemText(this.comboBoxName3.SelectedItem);
			switch (s)
			{
				case "Hamburger":
					lblid3.Text = "11110";
					lblPrice3.Text = "3.50";
					break;
				case "Cheeseburger":
					lblid3.Text = "11111";
					lblPrice3.Text = "4.00";
					break;
				case "Hot dog":
					lblid3.Text = "11112";
					lblPrice3.Text = "3.50";
					break;
				case "Chicken wings":
					lblid3.Text = "11113";
					lblPrice3.Text = "5.00";
					break;
				case "French fries":
					lblid3.Text = "11114";
					lblPrice3.Text = "3.00";
					break;
				case "Chicken doner":
					lblid3.Text = "11115";
					lblPrice3.Text = "6.00";
					break;
				case "Mixed doner":
					lblid3.Text = "11116";
					lblPrice3.Text = "7.00";
					break;
				case "Ketchup":
					lblid3.Text = "11120";
					lblPrice3.Text = "0.50";
					break;
				case "Mayo":
					lblid3.Text = "11121";
					lblPrice3.Text = "0.50";
					break;
				case "Chili":
					lblid3.Text = "11122";
					lblPrice3.Text = "0.50";
					break;
				case "Garlic sauce":
					lblid3.Text = "11123";
					lblPrice3.Text = "0.50";
					break;
				case "Coca Cola":
					lblid3.Text = "11130";
					lblPrice3.Text = "2.50";
					break;
				case "Fanta":
					lblid3.Text = "11131";
					lblPrice3.Text = "2.50";
					break;
				case "Water":
					lblid3.Text = "11132";
					lblPrice3.Text = "1.50";
					break;
				case "Beer":
					lblid3.Text = "11133";
					lblPrice3.Text = "3.00";
					break;

			}
		}

		private void comboBoxName4_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = this.comboBoxName4.GetItemText(this.comboBoxName4.SelectedItem);
			switch (s)
			{
				case "Hamburger":
					lblid4.Text = "11110";
					lblPrice4.Text = "3.50";
					break;
				case "Cheeseburger":
					lblid4.Text = "11111";
					lblPrice4.Text = "4.00";
					break;
				case "Hot dog":
					lblid4.Text = "11112";
					lblPrice4.Text = "3.50";
					break;
				case "Chicken wings":
					lblid4.Text = "11113";
					lblPrice4.Text = "5.00";
					break;
				case "French fries":
					lblid4.Text = "11114";
					lblPrice4.Text = "3.00";
					break;
				case "Chicken doner":
					lblid4.Text = "11115";
					lblPrice4.Text = "6.00";
					break;
				case "Mixed doner":
					lblid4.Text = "11116";
					lblPrice4.Text = "7.00";
					break;
				case "Ketchup":
					lblid4.Text = "11120";
					lblPrice4.Text = "0.50";
					break;
				case "Mayo":
					lblid4.Text = "11121";
					lblPrice4.Text = "0.50";
					break;
				case "Chili":
					lblid4.Text = "11122";
					lblPrice4.Text = "0.50";
					break;
				case "Garlic sauce":
					lblid4.Text = "11123";
					lblPrice4.Text = "0.50";
					break;
				case "Coca Cola":
					lblid4.Text = "11130";
					lblPrice4.Text = "2.50";
					break;
				case "Fanta":
					lblid4.Text = "11131";
					lblPrice4.Text = "2.50";
					break;
				case "Water":
					lblid4.Text = "11132";
					lblPrice4.Text = "1.50";
					break;
				case "Beer":
					lblid4.Text = "11133";
					lblPrice4.Text = "3.00";
					break;

			}

		}

		private void comboBoxName5_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = this.comboBoxName5.GetItemText(this.comboBoxName5.SelectedItem);
			switch (s)
			{
				case "Hamburger":
					lblid5.Text = "11110";
					lblPrice5.Text = "3.50";
					break;
				case "Cheeseburger":
					lblid5.Text = "11111";
					lblPrice5.Text = "4.00";
					break;
				case "Hot dog":
					lblid5.Text = "11112";
					lblPrice5.Text = "3.50";
					break;
				case "Chicken wings":
					lblid5.Text = "11113";
					lblPrice5.Text = "5.00";
					break;
				case "French fries":
					lblid5.Text = "11114";
					lblPrice5.Text = "3.00";
					break;
				case "Chicken doner":
					lblid5.Text = "11115";
					lblPrice5.Text = "6.00";
					break;
				case "Mixed doner":
					lblid5.Text = "11116";
					lblPrice5.Text = "7.00";
					break;
				case "Ketchup":
					lblid5.Text = "11120";
					lblPrice5.Text = "0.50";
					break;
				case "Mayo":
					lblid5.Text = "11121";
					lblPrice5.Text = "0.50";
					break;
				case "Chili":
					lblid5.Text = "11122";
					lblPrice5.Text = "0.50";
					break;
				case "Garlic sauce":
					lblid5.Text = "11123";
					lblPrice5.Text = "0.50";
					break;
				case "Coca Cola":
					lblid5.Text = "11130";
					lblPrice5.Text = "2.50";
					break;
				case "Fanta":
					lblid5.Text = "11131";
					lblPrice5.Text = "2.50";
					break;
				case "Water":
					lblid5.Text = "11132";
					lblPrice5.Text = "1.50";
					break;
				case "Beer":
					lblid5.Text = "11133";
					lblPrice5.Text = "3.00";
					break;
			}
		}

		private void comboBoxName6_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = this.comboBoxName6.GetItemText(this.comboBoxName6.SelectedItem);
			switch (s)
			{
				case "Hamburger":
					lblid6.Text = "11110";
					lblPrice6.Text = "3.50";
					break;
				case "Cheeseburger":
					lblid6.Text = "11111";
					lblPrice6.Text = "4.00";
					break;
				case "Hot dog":
					lblid6.Text = "11112";
					lblPrice6.Text = "3.50";
					break;
				case "Chicken wings":
					lblid6.Text = "11113";
					lblPrice6.Text = "5.00";
					break;
				case "French fries":
					lblid6.Text = "11114";
					lblPrice6.Text = "3.00";
					break;
				case "Chicken doner":
					lblid6.Text = "11115";
					lblPrice6.Text = "6.00";
					break;
				case "Mixed doner":
					lblid6.Text = "11116";
					lblPrice6.Text = "7.00";
					break;
				case "Ketchup":
					lblid6.Text = "11120";
					lblPrice6.Text = "0.50";
					break;
				case "Mayo":
					lblid6.Text = "11121";
					lblPrice6.Text = "0.50";
					break;
				case "Chili":
					lblid6.Text = "11122";
					lblPrice6.Text = "0.50";
					break;
				case "Garlic sauce":
					lblid6.Text = "11123";
					lblPrice6.Text = "0.50";
					break;
				case "Coca Cola":
					lblid6.Text = "11130";
					lblPrice6.Text = "2.50";
					break;
				case "Fanta":
					lblid6.Text = "11131";
					lblPrice6.Text = "2.50";
					break;
				case "Water":
					lblid6.Text = "11132";
					lblPrice6.Text = "1.50";
					break;
				case "Beer":
					lblid6.Text = "11133";
					lblPrice6.Text = "3.00";
					break;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			decimal x;
			x = (Convert.ToDecimal(lblPrice1.Text) * Convert.ToDecimal(txtQty1.Text)) +
				(Convert.ToDecimal(lblPrice2.Text) * Convert.ToDecimal(txtQty2.Text)) +
				(Convert.ToDecimal(lblPrice3.Text) * Convert.ToDecimal(txtQty3.Text)) +
				(Convert.ToDecimal(lblPrice4.Text) * Convert.ToDecimal(txtQty4.Text)) +
				(Convert.ToDecimal(lblPrice5.Text) * Convert.ToDecimal(txtQty5.Text)) +
				(Convert.ToDecimal(lblPrice6.Text) * Convert.ToDecimal(txtQty6.Text));
			lblTotal.Text = x.ToString();
		}
	}
}
