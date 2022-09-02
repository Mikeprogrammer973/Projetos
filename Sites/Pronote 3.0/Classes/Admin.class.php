<?php
@include_once("./Banco.class.php");
class Admin
{
    static $id; 

    static function Add($sql)
    {
        $connect = mysqli_connect("localhost","root","","pronote");
        return mysqli_query($connect,$sql);
        mysqli_close($connect);
    }

    static function Remove($sql)
    {
        $connect = mysqli_connect("localhost","root","","pronote");
        return mysqli_query($connect,$sql);
        mysqli_close($connect);
    }

    static function Arquivar($sql)
    {
        $connect = mysqli_connect("localhost","root","","pronote");
        return mysqli_query($connect,$sql);
        mysqli_close($connect);
    }

    static function Tranferir($sql)
    {
        $connect = mysqli_connect("localhost","root","","pronote");
        return mysqli_query($connect,$sql);
        mysqli_close($connect);
    } 
    
}


?>