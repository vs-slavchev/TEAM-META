<?php
require_once 'db_login_details.php';
require_once 'util.php';

$db_server = mysql_connect($db_hostname, $db_username, $db_password);
if (!$db_server) die(mysql_fatal_error("Unable to connect"));
mysql_select_db($db_database) or die(mysql_fatal_error("Unable to select database"));

if (isset($_POST['email']) &&
    isset($_POST['password']))
{
  $email = mysql_entities_fix_string($_POST['email']);
  $temp_pass = mysql_entities_fix_string($_POST['password']);

  $query = "SELECT password FROM users WHERE email = '$email';";
  $result = mysql_query($query);
  if (!$result) die (mysql_fatal_error("Denied access"));
  elseif (mysql_num_rows($result))
  {
    $row = mysql_fetch_row($result);
    $token = tokenize_password($email, $temp_pass);

    if ($token == $row[0])
    {
      session_start();
      $_SESSION['email'] = $email;
      header("Location: ../#/");
      session_write_close();
      exit();
    }
    else die("Invalid username/password combination. pass wrong");
  }
  else die("Invalid username/password combination. notfound");
}
?>
