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
            connectionString.Server = DatabaseDetails.SERVER;
            connectionString.Database = DatabaseDetails.DATABASE;
            connectionString.UserID = DatabaseDetails.USER;
            connectionString.Password = DatabaseDetails.PASSWORD;
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

        public Person GetPersonFromQRreader(string PcId)
        {
            string UserQrCode = "";
            Person visitor = null;
            MySqlDataReader readerUser = null, readerForDevice = null;
            try
            {
                // receive the scanned QR value
                Open();
                string query = String.Format(Queries.SELECT, "reader_device", "device_id", PcId);
                readerForDevice = ExecuteReaderQuery(query);
                while (readerForDevice.Read())
                {
                    UserQrCode = readerForDevice["qr_value"].ToString();
                }
                readerForDevice.Close();
                Close();
                if (UserQrCode.Equals(""))
                {
                    MessageBox.Show("QR scanner has NOT read a value!", "Warning");
                    return null;
                }

                // use the QR value to find the user
                string user_query = String.Format(Queries.SELECT, "user", "qr_code", UserQrCode);
                Open();
                readerUser = ExecuteReaderQuery(user_query);
                while (readerUser.Read())
                {
                    visitor = new Person(readerUser);
                }
                Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (readerForDevice != null)
                {
                    readerForDevice.Close();
                }
                if (readerUser != null)
                {
                    readerUser.Close();
                }
            }

            if (visitor == null)
            {
                MessageBox.Show("Invalid visitor information!", "Error");
            }

            return visitor;
        }

        public void NullQRvalueInDB(string PcId)
        {
            try
            {
                Open();
                string query = String.Format(Queries.NULL_QR_READER_DEVICE, PcId);
                ExecuteNonQuery(query);
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}




/*  TODO:
 * 
 *  - list free camp spots
 * 
 */
