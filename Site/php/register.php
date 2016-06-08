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
  $camp_select = mysql_entities_fix_string($_POST['selectCamp']);

  $qr_code = generate_qr_code($email);

  #values if no camp is to be reserved
  $camp_id = "NULL";
  $total_money_owed = $entrance_cost;

  if ($camp_select != "NULL")
  {
    #NULL doesn't need single quotes but a valid value does
    $camp_id = "'" . $camp_select . "'";
    #only the person making the reservation pays the camp reservation cost
    $total_money_owed += $camp_reservation_cost;

    #set camp organizer
    $query = "UPDATE camp
              SET user_count = 1, organizer_code = '$qr_code'
              WHERE camp_id = $camp_id;";
    $result = mysql_query($query);
    if (!$result) die (mysql_fatal_error("Denied access"));

    session_start();
    $_SESSION['camp_id'] = $camp_id;
    $_SESSION['organizer_code'] = $qr_code;
    session_write_close();
  }

  $query = "INSERT INTO user (email, first_name, last_name,
            paypal, phone_number, qr_code, camp_id, money_owed)
            VALUES ('$email', '$first_name', '$last_name',
            '$paypal', '$phone_number', '$qr_code', $camp_id, $total_money_owed);";
  $result = mysql_query($query);
  if (!$result) die (mysql_fatal_error("Denied access"));

  header("Location: ../email.html");

} else
{
  echo "<h1>You didn't input all fields!</h1>";
}

mysql_close($db_server);
?>
