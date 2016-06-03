<?php
require_once 'db_login_details.php';

// Util functions
function tokenize_qr_code($email)
{
  $left_salt = $salt1 . strrev($email);
  $right_salt = strlen($email) . $salt2;
  return sha1("$left_salt$email$right_salt");
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
