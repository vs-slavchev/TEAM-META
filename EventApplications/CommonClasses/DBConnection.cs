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

        public List<Person> SelectVisitor(string dbField, string value)
        {
            MySqlDataReader reader = null;
            List<Person> visitors = new List<Person>();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT * "
                                + "FROM user "
                                + "WHERE " + dbField + " = '" + value + "';";

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    visitors.Add(new Person(reader));
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
            }
            return null;
        }

        public int ScalarCount(string dbCondition, string dbTable)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) "
                                + "FROM " + dbTable + " "
                                + "WHERE " + dbCondition + ";";

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            return -1;
        }

        public double ScalarSum(string dbField, string dbTable)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT SUM(" + dbField + ") "
                                + "FROM " + dbTable + ";";

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            return -1;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
