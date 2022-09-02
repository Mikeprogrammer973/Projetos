<?php
@include_once("Banco.class.php");
@include_once("Admin.class.php");
@include_once("Prof.class.php");
@include_once("Aluno.class.php");
session_start();
class User
{
    function __construct()
    {
        
    }

    static function Login($function,$ca)
    {//Realiza processo de verificação ao logar
        if($_COOKIE["ca"] != "")
        {
            unset($_COOKIE["ca"]);
        }
        if($_COOKIE["function"] != "")
        {
            unset($_COOKIE["function"]);
        }
        switch($function)
        {
            case "adm":
                $consult = Banco::Select("SELECT * FROM adms WHERE code_adm = '".$ca."' AND status = 'C'");
                if(count($consult) > 0)
                    {
                        if($consult[0]["code_adm"] == $ca)
                        {
                            
                            User::Set_cookie("ca",$consult[0]["code_adm"]);
                            User::Set_cookie("function",$function);

                            $_SESSION["logado"] = true;
                            return "OK";
                        }
                    }
                    else
                    {
                        return "invalid_user";
                    }
               
                break;
            case "prof":
                $consult = Banco::Select("SELECT * FROM profs WHERE senha = '".$ca."' AND status = 'C'");
                
                    if(count($consult) > 0)
                    {
                        if($consult[0]["code_prof"] == $ca)
                        {
                            
                            User::Set_cookie("ca",$consult[0]["code_prof"]);
                            User::Set_cookie("function",$function);

                            $_SESSION["logado"] = true;
                            return "OK";
                        }
                    }
                    else
                    {
                        return "invalid_user";
                    }
                
                break;
            case "aluno":
                $consult = Banco::Select("SELECT * FROM alunos WHERE senha = '".$ca."' AND status = 'C'");
                
                    if(count($consult) > 0)
                    {
                        if($consult[0]["matricula"] == $ca)
                        {
                            
                            User::Set_cookie("ca",$consult[0]["matricula"]);
                            User::Set_cookie("function",$function);

                            $_SESSION["logado"] = true;
                            return "OK";
                        }
                    }
                    else
                    {
                        return "invalid_user";
                    }
                
                break;
        }
    }

    static function Logout()
    {
        unset($_SESSION["logado"]);
        unset($$_COOKIE["ca"]);
        unset($$_COOKIE["function"]);
        if(session_destroy())
        {
            return "OK";
        }
        else
        {
            return "NO";
        }
    }
    
    static function Create_Account($tipo,$info)
    {//Realiza processo de salvar dados na banco ao cadastrar
        switch($tipo)
        {
            case "adm":
                $consult = Banco::Select("SELECT * FROM adms WHERE code_adm = '".$info[0]."'");
                if(count($consult) == 0)
                {
                    $query = Banco::Insert("INSERT INTO adms (code_adm,nome_completo,foto_perfil_adm,email) VALUES ('".$info[0]."','".$info[1]."','".addslashes($info[2])."','".$info[3]."')");
                    return $query;
                }
                else if($consult != "A conexão falhou!" && $consult != "O query falhou!")
                {
                    return "existente";
                }
                else
                {
                    return $consult;
                }
                break;
            case "prof":
                $consult = Banco::Select("SELECT * FROM profs WHERE code_prof = '".$info[1]."'");
                if(count($consult) == 0)
                {
                    $query = Banco::Insert("INSERT INTO profs (code_escola,code_prof,nome_completo,foto_perfil_prof,senha) VALUES ('".$info[0]."','".$info[1]."','".$info[2]."','".$info[3]."','".$info[1]."')");
                    return $query;
                }
                else if($consult != "A conexão falhou!" && $consult != "O query falhou!")
                {
                    return "existente";
                }
                else
                {
                    return $consult;
                }
                break;
            case "aluno":
                $consult = Banco::Select("SELECT * FROM alunos WHERE matricula = '".$info[1]."'");
                if(count($consult) == 0)
                {
                    $query = Banco::Insert("INSERT INTO alunos (code_escola,matricula,nome_completo,foto_perfil_aluno,code_turma,senha) VALUES ('".$info[0]."','".$info[1]."','".$info[2]."','".$info[3]."','".$info[4]."','".$info[1]."')");
                    return $query;
                }
                else if($consult != "A conexão falhou!" && $consult != "O query falhou!")
                {
                    return "existente";
                }
                else
                {
                    return $consult;
                }
                break;
        }
    }

    static function Delete_Account()
    {//Processo para deletar conta

    }

    static function Convert_img_byte($file,$dr,$size,$type)
    {
        if($size > (1024 * 1204 * 2))
        {
            return "error_size";
        }
        else
        {
            if($type == "image/png")
            {
                $ponteiro = fopen($dr.$file,"r");
                $img_byte = fread($ponteiro,$size);
                fclose($ponteiro);
                return $img_byte;
            }
            else
            {
                return "error_extension";
            }
        }
    }

    static function Set_cookie($nome,$dado)
    {//Realiza processo de criar cookies
       //Criar cookie
        setcookie($nome,$dado,0,"/","",false,false);
    }
}

?>