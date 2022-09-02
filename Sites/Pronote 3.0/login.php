<?php
require_once("./Classes/User.class.php");
@$function = $_REQUEST["function"];
@$senha = $_REQUEST["senha"];

$result = User::Login($function, $senha);

echo $result;

?>