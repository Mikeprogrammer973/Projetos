<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Mega Quiz <-> Pergunta 1</title>
</head>
<body>
<?php
	include_once("quiz.php");
    @$category = $_REQUEST['category'];
    @$ref = $_REQUEST['ref'];
    $id_ask = random_int(1, 5);
    $destino = "ask_2.php";
    
    GeraPergunta($category,$id_ask,$destino,$ref);
?>
</body>
</html>
