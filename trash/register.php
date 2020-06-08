<?php
//OLD AND PASTED CODE (2019)
//UNSAFE AS FUCK DUE TO SQL INJECTION VULNERABILITY 
//make sure to fix and maybe improve ghetto methods i used(i was just a beginner in php(i mean i still am))
$servername = "localhost";
$username   = "n4h";
$password   = "";
$dbname     = "accdbase";
$ip = $_SERVER["REMOTE_ADDR"];
$timestamp = strtotime("+3 days");
$expiry = date("Y-m-d H:i:s", $timestamp);
// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);
$con = mysqli_connect($servername, $username, $password, $dbname);
$connn = mysqli_connect($servername, $username, $password, $dbname);
$conn3 = mysqli_connect($servername, $username, $password, $dbname);
// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
$json = file_get_contents("https://ip.teoh.io/api/vpn/$ip");
$arr = json_decode($json);
$vpn = $arr->vpn_or_proxy;
if($vpn == "yes"){
	die("vpn");
}
$query3 = mysqli_query($conn3, "SELECT * FROM accounts WHERE ip='".$ip."'");
if(!$query3){
	die('Error');
}
if(mysqli_num_rows($query3) > 0){

    die("overuse");

}
$login = $_POST["login"];
$password = $_POST["password"];
$identifier = $_POST["identifier"];
$query2 = mysqli_query($con, "SELECT * FROM accounts WHERE namehash='".$login."'");

    if (!$query2)
    {
        die('Error');
    }

if(mysqli_num_rows($query2) > 0){

    echo "fail";

}else{
$sql = "INSERT INTO accounts (namehash, passhash, identifier, blacklist, expiry, ip) VALUES (\"$login\", \"$password\", \"$identifier\", 0, \"$expiry\", \"$ip\");";
$result = mysqli_query($conn, $sql);
$table = "db$login";
if($result)
{
$query3 = "CREATE TABLE $table(ID int PRIMARY KEY AUTO_INCREMENT, owner text, packet text, packet2 text, packet3 text, ip text, date text);";
$result3 = mysqli_query($connn, $query3);
if($result3){
echo "success";

}
}

else
{
die("fail ");
}

}

    
?>