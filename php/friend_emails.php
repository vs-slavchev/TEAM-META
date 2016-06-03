<?php
require_once 'db_login_details.php';
require_once 'util.php';

$db_server = mysql_connect($db_hostname, $db_username, $db_password);
if (!$db_server) die(mysql_fatal_error("Unable to connect"));
mysql_select_db($db_database) or die(mysql_fatal_error("Unable to select database"));


for ($i = 1; $i <=5; $i++)
{
  $field_name = 'email' . (string)$i;
  if (isset($_POST[$field_name]) && !empty($_POST[$field_name]))
  {
    $email = mysql_entities_fix_string($_POST[$field_name]);

    $token = tokenize_qr_code($email);
    $query = "INSERT INTO user (email, qr_code) VALUES ('$email', '$token');";

    $result = mysql_query($query);
    if (!$result) die (mysql_fatal_error("Denied access"));
  }
}

header("Location: ../index.html");


mysql_close($db_server);
?>
