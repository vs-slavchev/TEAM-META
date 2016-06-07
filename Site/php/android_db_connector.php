<?php
require_once 'db_login_details.php';

$con=mysqli_connect($db_hostname,$db_database,$db_password,$db_username);

if (mysqli_connect_errno($con)){
   echo "Failed to connect to MySQL: " . mysqli_connect_error();
}

$phone_id = $_POST['phone_id'];
$qr_value = $_POST['qr_value'];

$result = mysqli_query($con,"UPDATE reader_device SET qr_value='$qr_value' WHERE qr_value IS NULL AND device_id='$phone_id'");

echo mysqli_affected_rows($con);

mysqli_close($con);
?>
