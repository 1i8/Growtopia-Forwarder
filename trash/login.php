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
// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
$login = $_POST["login"];
$password = $_POST["password"];
$identifier = $_POST["identifier"];
$sql = "SELECT namehash, passhash, identifier, blacklist, expiry FROM accounts WHERE namehash = \"$login\" AND passhash = \"$password\"";
$result = mysqli_query($conn, $sql);

while($row = mysqli_fetch_assoc($result)) { 

if (mysqli_num_rows($result) > 0 && $row["identifier"] == $identifier && $row["blacklist"] != 1) 
{
    $expiry = $row["expiry"];
	$timestamp = strtotime($expiry);
	$timestamp2 = strtotime("now");
	if($timestamp > $timestamp2){
    echo("success|$expiry");
	}
	else{
		echo("expired");
	}
}
else if (mysqli_num_rows($result) > 0 && $row["blacklist"] == 1) 
{
    
    echo("ban");
}
else if(mysqli_num_rows($result) > 0)
{
    echo("stolen");
}
else
{
    echo("fail");
}
}
    
?>