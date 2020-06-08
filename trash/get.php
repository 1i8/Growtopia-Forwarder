
<?php
include 'encrypt.php';
//OLD AND PASTED CODE (2019)
//UNSAFE AS FUCK DUE TO SQL INJECTION VULNERABILITY 
//make sure to fix and maybe improve ghetto methods i used(i was just a beginner in php(i mean i still am))
$servername = "localhost";
$username   = "n4h";
$password   = "";
$dbname     = "accdbase";

$conn  = mysqli_connect($servername, $username, $password, $dbname);
$connn = mysqli_connect($servername, $username, $password, $dbname);
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$owner   = $_POST["owner"];
$autid   = $_POST["autid"];
$ident = $_POST["ident"];
$dbtable = "db$owner";
$stmt    = $connn->prepare("SELECT namehash, passhash, identifier FROM accounts WHERE namehash = ? AND passhash = ? AND identifier = ?");
$stmt->bind_param("sss", $owner, $autid, $ident);
if ($stmt->execute()) {
	$stmt->store_result();
    $numberofrows = (int)$stmt->num_rows;
    if ($numberofrows > 0) {
        $sql    = "SELECT ID, packet, packet2, packet3, date, ip FROM $dbtable";
        $result = mysqli_query($conn, $sql);
        
        if (mysqli_num_rows($result) > 0) {
            // output data of each row
            while ($row = mysqli_fetch_assoc($result)) {
                echo '^' . '|' . (string) $row["ID"] . '|' . '|' . $row["packet"] . '|' . '|' . $row["packet2"] . '|' . '|' . $row["packet3"] . '|' . '|' . $row["ip"] . '|' . '|' . $row["date"] . '|' . '^'; // ID|packet|packet2|packet3|ip|date    //0|1|2|3|4|5
            }
        } else {
            echo "You don't have any accounts";
        }
        
        mysqli_close($conn);
    }
	else{
		die("unauthorized");
	}
}
else {
	echo("dead");
}
?>
 
