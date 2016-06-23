<?php
require_once 'db_login_details.php';
require_once 'util.php';

$db_server = mysql_connect($db_hostname, $db_username, $db_password);
if (!$db_server) die(mysql_fatal_error("Unable to connect"));
mysql_select_db($db_database) or die(mysql_fatal_error("Unable to select database"));

if (isset($_POST['email']) &&
    isset($_POST['first_name']) &&
    isset($_POST['last_name']) &&
    isset($_POST['paypal']) &&
    isset($_POST['phone_number']))
{

  $email = mysql_entities_fix_string($_POST['email']);
  $first_name = mysql_entities_fix_string($_POST['first_name']);
  $last_name = mysql_entities_fix_string($_POST['last_name']);
  $paypal = mysql_entities_fix_string($_POST['paypal']);
  $phone_number = mysql_entities_fix_string($_POST['phone_number']);


  $query = "UPDATE user SET
            first_name = '$first_name', last_name = '$last_name',
            paypal = '$paypal', phone_number = '$phone_number'
            WHERE email = '$email';";
  $result = mysql_query($query);
  if (!$result) die (mysql_fatal_error("Denied access"));

  header("Location: ../index.html");

} else
{
  echo "<h1>You didn't input all fields!</h1>";
}

mysql_close($db_server);
?>
