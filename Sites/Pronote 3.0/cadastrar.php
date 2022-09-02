<?php
require_once("./Classes/User.class.php");
require_once("./Classes/Banco.class.php");
@$function = $_REQUEST["function"];
@$senha = $_REQUEST["senha"];
@$nome = $_REQUEST["nome"];
@$email = $_REQUEST["email"];

$dr = "./Tmp_Profile_Image/";



if(move_uploaded_file($_FILES["img"]["tmp_name"],$dr.$_FILES["img"]["name"])):
if($function == "prof" || $function == "aluno")
{
    header("location:index.php?error=denied_access");
}
else
{
    $img = User::Convert_img_byte($_FILES["img"]["name"],$dr,$_FILES["img"]["size"],$_FILES["img"]["type"]);
    if($img == "error_size")
    {
        header("location:index.php?error=invalid_size");
    }
    else if($img == "error_extension")
    {
        header("location:index.php?error=invalid_extension");
    }
    else
    {
        $consult = Banco::Select("SELECT * FROM adms WHERE email = '".$email."'");
        if(count($consult)  == 0)
        {
            $dates = [$senha,$nome,$img,$email];
            $new_user = User::Create_Account("adm",$dates);
            if($new_user == "existente")
            {
                header("location:index.php?error=existing_user");
            }
            else if($new_user == "OK")
            {
                header("location:index.php?info=success");
            }
            else
            {echo $new_user;
                header("location:index.php?error=error_db");
            }
        }
        else if($consult == "O query falhou")
        {echo $consult;
            header("location:index.php?error=error_db");
        }
        else
        {
            header("location:index.php?error=existing_user");
        }
    }
}
unlink($dr.$_FILES["img"]["name"]);
exit;
endif;
header("location:index.php?error=move_img");
?>