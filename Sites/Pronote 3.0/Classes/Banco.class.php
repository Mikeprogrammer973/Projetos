<?php

class Banco
{
    #static $connect = mysqli_connect("localhost", "root", "", "pronote");

    function __construct()
    {
        
    }

    static function Select($sql)
    {
        $connect = mysqli_connect("localhost", "root", "", "pronote");
        $results = array();
        if($connect)
        {
            #mysqli_set_charset($connect,"utf8");
            if($q = mysqli_query($connect,$sql))
            {
                if(mysqli_num_rows($q) > 0)
                {
                    while ($r = mysqli_fetch_assoc($q)) 
                    {
                        $results[] = $r;
                    }                   
                    
                    return $results;
                }
                else
                {
                    return $results;
                }
                
            }
            else
            {
                return mysqli_error($connect);
            }
        }
        else
        {
            return "A conexão falhou!";
        }
        mysqli_close($connect);
    }

    static function Insert($sql)
    {
        if($connect = mysqli_connect("localhost", "root", "", "pronote"))
        {
            #mysqli_set_charset($connect,"utf8");
            if(mysqli_query($connect,$sql))
            {
                return "OK";
            }
            else
            {
                return mysqli_error($connect);
            }
        }
        else
        {
            return "A conexão falhou!";
        }
        mysqli_close($connect);
    }

    static function Delete($sql)
    {
        if($connect = mysqli_connect("localhost", "root", "", "pronote"))
        {
            #mysqli_set_charset($connect,"utf8");
            if(mysqli_query($connect,$sql))
            {
                return "OK";
            }
            else
            {
                return "NO";
            }
        }
        else
        {
            return "A conexão falhou!";
        }
        mysqli_close($connect);
    }

    static function Update($sql)
    {
        if($connect = mysqli_connect("localhost", "root", "", "pronote"))
        {
            #mysqli_set_charset($connect,"utf8");
            if(mysqli_query($connect,$sql))
            {
                return "OK";
            }
            else
            {
                return "NO";
            }
        }
        else
        {
            return "A conexão falhou!";
        }
        mysqli_close($connect);
    }
}

?>