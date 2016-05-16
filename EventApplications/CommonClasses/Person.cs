using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Person
    {
        public string Id { get; private set; }
        public string Email { get; private set; }
        public string First_name { get; private set; }
        public string Last_name { get; private set; }
        public string Phone_number { get; private set; }

        public Person(string id, string email, string first_name, string last_name, string phone_number)
        {
            this.Id = id;
            this.Email = email;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Phone_number = phone_number;
        }

        public override string ToString()
        {
            return "id: " + Id + "; first name: " + First_name
                + "; last name: " + Last_name + "; email: " + Email;
        }
    }
}
