<?php
require_once 'db_login_details.php';
require_once 'util.php';

$db_server = mysql_connect($db_hostname, $db_username, $db_password);
if (!$db_server) die(mysql_fatal_error("Unable to connect"));
mysql_select_db($db_database) or die(mysql_fatal_error("Unable to select database"));

if (isset($_POST['email']) &&
    isset($_POST['password']) &&
    isset($_POST['confirm_password']))
{

  $email = mysql_entities_fix_string($_POST['email']);
  $password = mysql_entities_fix_string($_POST['password']);
  $confirm_password = mysql_entities_fix_string($_POST['confirm_password']);


if ($password == $confirm_password)
{
  add_user($email, $password);
  header("Location: ../#/");
  #maybe tell user to log in with their new acc
} else
{
  echo "<h1>You didn't input all fields!</h1>";
}

mysql_close($db_server);
?>
