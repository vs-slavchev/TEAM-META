﻿using System;
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
        private string config = "server=athena01.fhict.local; database=dbi345959; userid=dbi345959; password=2XArGTUPc9;";

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

        public Person ExecuteSelect(string user_id)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT user_id, first_name, last_name, phone_number FROM user WHERE user_id = '@user_id';";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@user_id", user_id);

                reader = cmd.ExecuteReader();
                string id = reader.GetString(0);
                string first_name = reader.GetString(1);
                string last_name = reader.GetString(2);
                string phone_number = reader.GetString(3);

                while (reader.Read())
                {
                    return new Person(id, first_name, last_name, phone_number);
                }
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
            return null;
        }

        public void Close()
        {
            connection.Close();
        }

    }
}
