<?php
//OLD AND PASTED CODE (2019)
//UNSAFE AS FUCK DUE TO SQL INJECTION VULNERABILITY 
//make sure to fix and maybe improve ghetto methods i used(i was just a beginner in php(i mean i still am))
$servername = "localhost";
$username   = "n4h";
$password   = "";
$dbname     = "accdbase";
$ip = $_SERVER['REMOTE_ADDR'];

date_default_timezone_set('Europe/London');
$date = date('m/d/Y h:i:s', time());

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);
// Check connection
if (!$conn) {
    die("Connection failed");
}
$log = $_POST['owner'];
$table = "db$log";
$packet = $_POST['packet'];
$packet2 = $_POST['packet2'];
$packet3 = $_POST['packet3'];
$sql = "INSERT INTO $table (owner, packet, packet2, packet3, ip, date)
VALUES ('$log', '$packet', '$packet2', '$packet3', '$ip', '$date')";

if (mysqli_query($conn, $sql)) {
    echo "success ";
} else {
    echo "fail $conn->error";
}

mysqli_close($conn);
?>