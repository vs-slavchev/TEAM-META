<?php
session_start();
if (!isset($_SESSION['email']))
{
  echo "you were NOT logged in";
}
echo "<h1> You are logging out as: " . $_SESSION['email'] . "</h1>";

session_unset();
session_destroy();
?>
