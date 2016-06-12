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
		public static readonly string MONEY_FORMAT = "{0:0.00} €",

		SELECT = "SELECT * "
			   + "FROM {0} "
			   + "WHERE {1} = '{2}';",

		SELECT_SUM = "SELECT SUM({0}) "
				   + "FROM {1};",

		SELECT_COUNT = "SELECT COUNT(*) "
					 + "FROM {0} "
					 + "WHERE {1};",

		USER_UPDATE = "UPDATE user "
					+ "SET {0} = {1} "
					+ "WHERE qr_code = {2};",

		NULL_QR_READER_DEVICE = "UPDATE reader_device "
							  + "SET qr_value = NULL "
							  + "WHERE device_id = {0};",

		DELETE_LOAN_MATERIAL = "DELETE FROM `material_loan` "
							 + "WHERE `user_qr`= '{0}' AND `material_id`={1}",

		UPDATE_MATERIAL_QUANTITY = "UPDATE `material` SET `quantity_left`=`quantity_left` + {0} "
								 + "WHERE `material_id` = {1}",

		INSERT_MATERIAL_LOAN = "INSERT INTO `material_loan`(`user_qr`, `material_id`) "
														   + "VALUES('{0}', {1})",

		USER_INSERT = "INSERT INTO user "
					+ "(email, first_name, last_name, phone_number, paypal, qr_code, money_owed) "
					+ "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', 55.00);",

		SELECT_MONEY_SPENT_FOOD = "SELECT SUM(p.cost) AS FOOD_COST "
								+ "FROM ( "
									+ "SELECT price * quantity AS cost "
									+ "FROM purchase JOIN product "
									+ "USING (product_id) "
									+ "WHERE category LIKE '%food%' AND user_qr = '{0}') p",

		SELECT_MONEY = "SELECT money"
					 + "FROM user"
					 + "WHERE qr_code = '{0}'",

		MONEY_UPDATE = "UPDATE user "
					+ "SET money = money - {0} "
					+ "WHERE qr_code = '{1}';",

		PURCHASE_INSERT = "INSERT INTO purchase"
						+ "(user_qr, product_id, shop_id, quantity)"
						+ "VALUES ('{0}', '{1}', '{2}', '{3}');";
    }
}
