<?php
require_once 'util.php';

$email = $_POST['email'];
echo generate_qr_code($email);

?>
