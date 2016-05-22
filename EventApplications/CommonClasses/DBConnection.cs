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

            connection = new MySqlConnection(connectionString.ToString());
        }

        public void Open()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public MySqlDataReader ReaderQuery(string dbCondition, string dbTable)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT * "
                                + "FROM " + dbTable + " "
                                + "WHERE " + dbCondition + ";";

                return cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
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

        public void ExecuteNonQuery(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

    }
}
