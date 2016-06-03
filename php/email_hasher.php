<?php
require_once 'util.php';

$email = $_POST['email'];
echo tokenize_qr_code($email);

?>
