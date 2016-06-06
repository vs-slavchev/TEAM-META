<?php
require_once 'db_login_details.php';
require_once 'util.php';

session_start();
$camp_id = "";
if (isset($_SESSION['camp_id']))
{
  $camp_id = $_SESSION['camp_id'];
}
session_unset();
session_destroy();


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
    $query = "INSERT INTO user (email, qr_code, camp_id) VALUES ('$email', '$token', '$camp_id');";

    $result = mysql_query($query);
    if (!$result) die (mysql_fatal_error("Denied access"));
  }
}

header("Location: ../index.html");


mysql_close($db_server);
?>


require_once 'php/db_login_details.php';
require_once 'php/util.php';

$conn = mysqli_connect($db_hostname, $db_username, $db_password, $db_database);
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$sql = "SELECT * FROM camp WHERE user_count = 0;";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
    while($row = mysqli_fetch_assoc($result)) {
      $camp_num = $row["camp_id"];

      #$heredoc = <<<term
      #<option value=" $camp_num ">Camp $camp_num </option>
      #term;
      echo $heredoc;
    }
} else {
    echo "No empty camps, sorry!";
}
