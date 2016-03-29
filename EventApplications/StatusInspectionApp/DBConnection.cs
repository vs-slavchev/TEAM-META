using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Status_InspectionApp
{

    /* The database connection class is a singleton. It will not have state, so using a global structure
     * is not supposed to affect our architecture in a negative way. 
     */

    class DBConnection
    {
        private MySqlConnection connection = null;
        private static DBConnection instance = null;
        private string config = "Server=localhost; database=dbi345959; UID=dbi345959; password=2XArGTUPc9";

        public static DBConnection Instance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }

        private DBConnection()
        {
            try
            {
                connection = new MySqlConnection(config);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public Person ExecuteSelect(string clientId)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Authors(Name) VALUES(@Name)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Name", "Trygve Gulbranssen");

                reader = cmd.ExecuteReader();

                return new Person(reader); // reader is of type MySqlDataReader

                // put in person constructor
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + ": "
                        + reader.GetString(1));
                }
                // till here

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
                    connection.Close();
                }
            }
        }

        public void Close()
        {
            connection.Close();
        }
                
    }
}
