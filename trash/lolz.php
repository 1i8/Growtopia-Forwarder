<?php
//OLD AND PASTED CODE (2019)
//UNSAFE AS FUCK DUE TO SQL INJECTION VULNERABILITY 
//make sure to fix and maybe improve ghetto methods i used(i was just a beginner in php(i mean i still am))
$servername = "localhost";
$username   = "n4h";
$password   = "";
$dbname     = "accdbase";

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);
$con = mysqli_connect($servername, $username, $password, $dbname);
$connn = mysqli_connect($servername, $username, $password, $dbname);
// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
$login = $_POST["login"];
$sql = "UPDATE accounts SET blacklist = \"true\" WHERE namehash = \"$login\";";
$result = mysqli_query($conn, $sql);
$table = "db$login";
if($result)
{
echo "success";

}


else
{
die("fail ");
}


?>