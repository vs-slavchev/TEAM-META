using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    /*
     * Contains predefined query strings with placeholders.
     * 
     * Use example:
     * 
     *      string queryString = String.Format(Queries.USER_INSERT,
     *                           email, firstName, lastName, phoneNumber, paypal);
     */
    public static class Queries
    {
        public static readonly string USER_INSERT = "INSERT INTO user "
            + "(email, first_name, last_name, phone_number, paypal) "
            + "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');";
        public static readonly string USER_UPDATE = "UPDATE user "
            + "SET {0} = {1} "
            + "WHERE user_id = {2};";
    }
}
