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
        private MySqlConnection mysqlConnection = null;

        public DBConnection()
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "athena01.fhict.local";
            connectionString.Database = "dbi345959";
            connectionString.UserID = "dbi345959";
            connectionString.Password = "2XArGTUPc9";
            connectionString.ConnectionTimeout = 30;

            mysqlConnection = new MySqlConnection(connectionString.ToString());
        }

        public void Open()
        {
            try
            {
                mysqlConnection.Open();
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
                mysqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private MySqlCommand createCommand(string query)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mysqlConnection;
            cmd.CommandText = query;
            return cmd;
        }

        public MySqlDataReader ExecuteReaderQuery(string query)
        {
            try
            {
                return createCommand(query).ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            return null;
        }

        public double ExecuteScalar(string query)
        {
            try
            {
                return Convert.ToDouble(createCommand(query).ExecuteScalar());
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
                createCommand(query).ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
