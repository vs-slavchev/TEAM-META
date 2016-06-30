using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using CommonClasses;

namespace Loaning_materialsApp
{
    class Material
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Price { get; set; }
        public string Renter { get; set; }

        public Material(MySqlDataReader reader)
        {
            ID = reader.GetInt32("material_id");
            Name = reader.GetString("type");
            Price = reader.GetDecimal("rent_price");
            Renter = reader.GetString("user_qr");
        }

        public Material(ListViewItem listItem, Person visitor)
        {
            if (visitor == null)
            {
                MessageBox.Show("No user is selected");
                return;
            }
            ID = Convert.ToInt32(listItem.SubItems[1].Text);
            Name = listItem.SubItems[2].Text;
            Price = Convert.ToDecimal(listItem.SubItems[3].Text);
            Renter = visitor.QR_code;
            listItem.SubItems[4].Text = Convert.ToString(
                        Convert.ToInt32(listItem.SubItems[4].Text) - 1);
        }
    }
}
