using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CommonClasses
{
    public class DBConnection
    {
        private MySqlConnection connection = null;
        private MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();

        public DBConnection()
        {
            connectionString.Server = "athena01.fhict.local";
            connectionString.Database = "dbi345959";
            connectionString.UserID = "dbi345959";
            connectionString.Password = "2XArGTUPc9";
            connectionString.ConnectionTimeout = 30;

            try
            {
                connection = new MySqlConnection(connectionString.ToString());
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public List<Person> ExecuteSelectVisitor(string dbField, string value)
        {
            MySqlDataReader reader = null;
            List<Person> visitors = new List<Person>();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT user_id, email, first_name, last_name, phone_number "
                                + "FROM users WHERE " + dbField + " = '" + value + "';";

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string email = reader.GetString(1);
                    string first_name = reader.GetString(2);
                    string last_name = reader.GetString(3);
                    string phone_number = reader.GetString(4);
                    visitors.Add(new Person(id, email, first_name, last_name, phone_number));
                }
                return visitors;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection != null)
                {
                    //connection.Close();
                }
            }
            return null;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
