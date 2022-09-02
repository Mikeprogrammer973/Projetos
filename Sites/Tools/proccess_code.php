<?php
    require_once("C:\Users\Thaise\Desktop\Tools\Classes\crypt.class.php");

    $crypt = new Crypt();
    @$tipo = $_REQUEST["tipo"];
    @$txt = isset($_REQUEST["txt"])?$_REQUEST["txt"]:"A";

    $code = " ";

    if($tipo == "c")
    {
        $rdm = rand(1,7);

        switch($rdm)
        {
            case 1:
                $code = $crypt -> Binario_($txt);
                break;
            case 2:
                $code = ($crypt -> Morse_($txt)) == ""?default_code($txt):$crypt -> Morse_($txt);
                break;
            case 3:
                $code = ($crypt -> Tecla_($txt)) == ""?default_code($txt):$crypt -> Tecla_($txt);
                break;
            case 4:
                $code = ($crypt -> Tecla_r($txt)) == ""?default_code($txt):$crypt -> Tecla_r($txt);
                break;
            case 5:
                $code = ($crypt -> Tecla_m($txt)) == ""?default_code($txt):$crypt -> Tecla_m($txt);
                break;
            case 6:
                $code = ($crypt -> Alfa_Num($txt)) == ""?default_code($txt):$crypt -> Alfa_Num($txt);
                break;
            case 7:
                $code = ($crypt -> Alfa_rNum($txt)) == ""?default_code($txt):$crypt -> Alfa_rNum($txt);
                break;
        }

        
    }
    else
    {
        $code = " ";
        $str = explode(" ",$txt);
        for($i = 0; $i < count($str); $i++)
        {
           $code .= $crypt -> decode_($str[$i]) . " ";
        }
    }

    function default_code($l)
    {
        $crypt = new Crypt();

        return $code = $crypt -> Binario_($l);
    }

    echo $code;
?>