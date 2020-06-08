<?php
const key = "encryptionkeykey";
function encrypt($text)
{
	$key = key;  
	$IV = mcrypt_create_iv(mcrypt_get_iv_size(MCRYPT_RIJNDAEL_256, MCRYPT_MODE_CBC), MCRYPT_RAND); 

	return base64_encode(mcrypt_encrypt(MCRYPT_RIJNDAEL_256, $key, $text, MCRYPT_MODE_CBC, $IV)."-[--IV-[-".$IV); 
}
function decrypt($text)
{
	$key = key;   
	$text = base64_decode($text); 
	$IV = substr($text, strrpos($text, "-[--IV-[-") + 9);
	$text = str_replace("-[--IV-[-".$IV, "", $text);

	return rtrim(mcrypt_decrypt(MCRYPT_RIJNDAEL_256, $key, $text, MCRYPT_MODE_CBC, $IV), "\0");
}
?>