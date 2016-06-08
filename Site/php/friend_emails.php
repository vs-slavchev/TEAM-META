<?php
require_once 'db_login_details.php';
require_once 'util.php';

session_start();
$camp_id = "NULL";
$organizer_code = "NULL";
if (isset($_SESSION['camp_id']) && isset($_SESSION['organizer_code']))
{
  $camp_id = $_SESSION['camp_id'];
  $organizer_code = $_SESSION['organizer_code'];
}
session_unset();
session_destroy();


$db_server = mysql_connect($db_hostname, $db_username, $db_password);
if (!$db_server) die(mysql_fatal_error("Unable to connect"));
mysql_select_db($db_database) or die(mysql_fatal_error("Unable to select database"));

$number_guests = 0;
for ($i = 1; $i <=5; $i++)
{
  $field_name = 'email' . (string)$i;
  if (isset($_POST[$field_name]) && !empty($_POST[$field_name]))
  {
    $email = mysql_entities_fix_string($_POST[$field_name]);

    #add a guest entry and set the camp_id (can be NULL)
    $token = generate_qr_code($email);
    $query = "INSERT INTO user (email, qr_code, camp_id, money_owed)
              VALUES ('$email', '$token', $camp_id, $entrance_cost);";

    $result = mysql_query($query);
    if (!$result) die (mysql_fatal_error("Denied access"));
    $number_guests++;
  }
}

if ($number_guests > 0 && $camp_id != "NULL")
{
  #increase the money_owed of the organizer for each guest
  $guests_price = $number_guests * $guest_camp_cost;
  $query = "UPDATE user
            SET money_owed = money_owed + $guests_price
            WHERE qr_code = '$organizer_code';";

  $result = mysql_query($query);
  if (!$result) die (mysql_fatal_error("Denied access"));

  #increase the user_count in the camp
  $query = "UPDATE camp
            SET user_count = user_count + $number_guests
            WHERE camp_id = $camp_id;";

  $result = mysql_query($query);
  if (!$result) die (mysql_fatal_error("Denied access"));
}


header("Location: ../index.html");

mysql_close($db_server);
?>
