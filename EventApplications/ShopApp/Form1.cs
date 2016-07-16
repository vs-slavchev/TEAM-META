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
            materialSkinManager.ColorScheme = SkinColors.GetDefaultColor();

            connection = new DBConnection();
            products = new List<Product>();

            ShopId = PromptForShopId();
            PcId = StatusPanelController.PromptForPcId();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            try
            {
                if (person == null)
                {
                    throw new TeamMetaException("No visitor is selected!");
                }
                if (person.Money - total < 0)
                {
                    throw new TeamMetaException("Visitor only has " + person.Money + "€ out of the required " + total + "€ !");
                }
                if (total == 0)
                {
                    throw new TeamMetaException("The products list is empty!");
                }

                connection.Open();

                string[] commands = new string[products.Count + 1];
                for (int product_i = 0; product_i < products.Count; product_i++)
                {
                    string updateMoneyStr = String.Format(Queries.PURCHASE_INSERT,
                                     person.QR_code, products[product_i].Id, ShopId, products[product_i].Quantity);
                    commands[product_i] = updateMoneyStr;
                }
                string updateMoney = String.Format(Queries.MONEY_UPDATE, total, person.QR_code);
                int lastIndex = commands.Length - 1;
                commands[lastIndex] = updateMoney;
                bool transactionSuccess = connection.DoTransaction(commands);
                if (transactionSuccess)
                {
                    MessageBox.Show("Purchase successful!");
                }
                else
                {
                    throw new TeamMetaException("Payment was NOT successful!");
                }
            }
            catch (TeamMetaException tmex)
            {
                MessageBox.Show(tmex.Message);
                return;
            }
            finally
            {
                connection.Close();
                connection.NullQRvalueInDB(PcId);
                listBox1.Items.Clear();
                lb_visitorLastName.Text = "";
                lb_visitorFirstName.Text = "";
                numericUpDown1.Value = 1;
                lblTotal.Text = "0.00 €";
                products = new List<Product>();
            }
        }

        private void showTotal()
        {
            try
            {
                if (person == null)
                {
                    throw new TeamMetaException("No visitor is selected!");
                }

                total = 0;
                foreach (Product p in products)
                {
                    total += p.Price * p.Quantity;
                }
                lblTotal.Text = String.Format(Queries.MONEY_FORMAT, total);

                if (person.Money - total < 0)
                {
                    throw new TeamMetaException("Visitor doesn't have enough money!");
                }
            }
            catch (TeamMetaException tmex)
            {
                MessageBox.Show(tmex.Message);
                return;
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count <= 0)
                {
                    throw new TeamMetaException("No items are present!");
                }
                if (listBox1.SelectedItem == null)
                {
                    throw new TeamMetaException("No item is selected!");
                }

                products.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                foreach (Product a in products)
                {
                    listBox1.Items.Add(a.Info());
                }
                showTotal();
            }
            catch (TeamMetaException tmex)
            {
                MessageBox.Show(tmex.Message);
                return;
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
            lb_visitorLastName.Text = person.Last_name;
            lb_visitorFirstName.Text = person.First_name;
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

        private void productButtonClick(int productId)
        {
            if (person == null)
            {
                MessageBox.Show("No visitor is selected!");
                return;
            }
            listBox1.Items.Clear();
            Product p = createProduct(productId);
            products.Add(p);
            foreach (Product product in products)
            {
                listBox1.Items.Add(product.Info());
            }
            showTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productButtonClick(11110);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productButtonClick(11111);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productButtonClick(11112);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productButtonClick(11113);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productButtonClick(11114);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            productButtonClick(11115);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            productButtonClick(11116);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            productButtonClick(11120);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            productButtonClick(11121);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            productButtonClick(11122);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            productButtonClick(11123);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            productButtonClick(11130);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            productButtonClick(11131);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            productButtonClick(11132);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            productButtonClick(11133);
        }

        private Product createProduct(int productId)
        {
            switch (productId)
            {
                case 11110:
                    return new Product(productId, 3.50, "Hamburger", quantity);
                case 11111:
                    return new Product(productId, 4.00, "Cheeseburger", quantity);
                case 11112:
                    return new Product(productId, 3.50, "Hot dog", quantity);
                case 11113:
                    return new Product(productId, 5.00, "Chicken wings", quantity);
                case 11114:
                    return new Product(productId, 3.00, "French fries", quantity);
                case 11115:
                    return new Product(productId, 6.00, "Chicken doner", quantity);
                case 11116:
                    return new Product(productId, 7.00, "Mixed doner", quantity);
                case 11120:
                    return new Product(productId, 0.50, "Ketchup", quantity);
                case 11121:
                    return new Product(productId, 0.50, "Mayo", quantity);
                case 11122:
                    return new Product(productId, 0.50, "Chili", quantity);
                case 11123:
                    return new Product(productId, 0.50, "Garlic sauce", quantity);
                case 11130:
                    return new Product(productId, 2.50, "Coca Cola", quantity);
                case 11131:
                    return new Product(productId, 2.50, "Fanta", quantity);
                case 11132:
                    return new Product(productId, 1.50, "Water", quantity);
                case 11133:
                    return new Product(productId, 3.00, "Beer", quantity);
                default:
                    MessageBox.Show("Invalid product id supplied!");
                    return null;
            }
        }
    }
}
