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
        public double MoneyOwed { get; private set; }
        public bool HasEntered { get; private set; }
        public bool HasLeft { get; private set; }

        public Person(MySqlDataReader reader)
        {
            this.Id = reader["user_id"].ToString();
            this.Email = reader["email"].ToString();
            this.First_name = reader["first_name"].ToString();
            this.Last_name = reader["last_name"].ToString();
            this.Phone_number = reader["phone_number"].ToString();
            this.Money = Convert.ToDouble(reader["money"]);
            this.TotalMoney = Convert.ToDouble(reader["total_money"]);
            this.MoneyOwed = Convert.ToDouble(reader["money_owed"]);
            this.HasEntered = Convert.ToBoolean(reader["has_entered"]);
            this.HasLeft = Convert.ToBoolean(reader["has_left"]);
        }

        public override string ToString()
        {
            return "first name: " + First_name
                + "; last name: " + Last_name + "; email: " + Email;
        }
    }
}
