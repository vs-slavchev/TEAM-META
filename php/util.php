<?php
// Util functions
function db_connect()
{
  $db_server = mysql_connect($db_hostname, $db_username, $db_password);
  if (!$db_server) die(mysql_fatal_error("Unable to connect"));
  mysql_select_db($db_database) or die(mysql_fatal_error("Unable to select database"));
  return $db_server;
}

function tokenize_password($email, $pass)
{
  $salt1 = "i!y@l" . strrev($email);
  $salt2 = strlen($email) . "oim80";
  return sha1("$salt1$pass$salt2");
}

function add_user($email, $password)
{
  $token = tokenize_password($email, $password);
  $query = "INSERT INTO users (email, password) VALUES ('$email', '$token');";
  $result = mysql_query($query);
  if (!$result) die (mysql_fatal_error("Denied access"));
}

function mysql_fatal_error($msg)
{
  $sql_msg = mysql_error();
  echo <<<_END
  Sorry, an error occured:
  <p>$msg: $sql_msg</p>
  Click back and try again.
_END;
}

function mysql_entities_fix_string($string)
{
  return htmlentities(mysql_fix_string($string));
}

function mysql_fix_string($string)
{
  if (get_magic_quotes_gpc())
  {
    $string = stripslashes($string);
  }
  return mysql_real_escape_string($string);
}
?>
