using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CommonClasses
{
    public class Person
    {
        public string Id { get; private set; }
        public string Email { get; private set; }
        public string First_name { get; private set; }
        public string Last_name { get; private set; }
        public string Phone_number { get; private set; }
        public double Money { get; private set; }
        public double TotalMoney { get; private set; }
        public bool HasEntered { get; private set; }
        public bool HasLeft { get; private set; }

        public Person(MySqlDataReader reader)
        {
            this.Id = Convert.ToString(reader["user_id"]);
            this.Email = Convert.ToString(reader["email"]);
            this.First_name = Convert.ToString(reader["first_name"]);
            this.Last_name = Convert.ToString(reader["last_name"]);
            this.Phone_number = Convert.ToString(reader["phone_number"]);
            this.Money = Convert.ToDouble(reader["money"]);
            this.TotalMoney = Convert.ToDouble(reader["total_money"]);
            this.HasEntered = Convert.ToBoolean(reader["has_entered"]);
            this.HasLeft = Convert.ToBoolean(reader["has_left"]);
        }

        public override string ToString()
        {
            return "id: " + Id + "; first name: " + First_name
                + "; last name: " + Last_name + "; email: " + Email;
        }
    }
}
