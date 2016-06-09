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
        public static readonly string MONEY_FORMAT = "{0:0.00} €";
        public static readonly string USER_INSERT = "INSERT INTO user "
            + "(email, first_name, last_name, phone_number, paypal, qr_code) "
            + "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";

        public static readonly string USER_UPDATE = "UPDATE user "
                                                  + "SET {0} = {1} "
                                                  + "WHERE qr_code = {2};";

        public static readonly string SELECT = "SELECT * "
                                             + "FROM {0} "
                                             + "WHERE {1} = '{2}';";

        public static readonly string SELECT_SUM = "SELECT SUM({0}) "
                                                 + "FROM {1};";

        public static readonly string SELECT_COUNT = "SELECT COUNT(*) "
                                                   + "FROM {0} "
                                                   + "WHERE {1};";

        public static readonly string NULL_QR_READER_DEVICE = "UPDATE reader_device "
                                                  + "SET qr_value = NULL "
                                                  + "WHERE device_id = {0};";

        public static readonly string DELETE_LOAN_MATERIAL = "DELETE FROM `material_loan` "
                                                           + "WHERE `user_qr`={0} AND `material_id`={1}";

        public static readonly string UPDATE_MATERIAL_QUANTITY = "UPDATE `material` SET `quantity_left`=`quantity_left` + {0} "
                                                               + "WHERE `material_id` = {1}";

        public static readonly string INSERT_MATERIAL_LOAN = "INSERT INTO `material_loan`(`user_qr`, `material_id`) "
                                                           + "VALUES({0}, {1})";

    }
}
