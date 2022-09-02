<?php
    @include_once("../Classes/Banco.class.php");
    @include_once("../Classes/Admin.class.php");
    @include_once("../Classes/User.class.php");

    @$categoria = $_REQUEST["categoria"];
    @$tipo = $_REQUEST["tipo"];
    @$datos = json_decode($_REQUEST["datos"]);

    $info = array();

    switch($categoria)
    {
        case "escolas":
            if($tipo == "info")
            {//Retornar matriz com as informações das escolas existentes
               $escolas_exitentes = Banco::Select("SELECT * FROM escolas WHERE code_adm_escola = '" . $_COOKIE['ca'] . "' AND status = 'C'");
                if(count($escolas_exitentes) > 0)
                {
                    
                    for($c = 0; $c < count($escolas_exitentes); $c++)
                    {
                        $alunos = Banco::Select("SELECT * FROM alunos WHERE code_escola = '" . $escolas_exitentes[$c]["code_escola"] . "' AND status = 'C'");
                        $profs = Banco::Select("SELECT * FROM profs WHERE code_escola = '" . $escolas_exitentes[$c]["code_escola"] . "' AND status = 'C'");
                        $mat = Banco::Select("SELECT * FROM cargos_prof WHERE code_escola = '" . $escolas_exitentes[$c]["code_escola"] . "' AND status = 'C'");
                        $info[$c] = array($escolas_exitentes[$c]["code_escola"],$escolas_exitentes[$c]["nome_escola"],$escolas_exitentes[$c]["status"],base64_encode($escolas_exitentes[$c]["foto_perfil_escola"]),count($alunos),count($profs),count($mat));
                    }
                }
                echo json_encode($info);
            }
            elseif($tipo == "add")
            {
                $sql = "INSERT INTO escolas (code_escola,nome_escola,code_adm_escola,foto_perfil_escola) VALUES 
                ('".$datos[0]."','".$datos[1]."','".$datos[2]."','".addslashes($datos[3])."')";
                
                if(Admin::Add($sql))
                {
                    echo "OK";
                }
                else
                {
                    echo "NO";
                }
            }
    }
    

?>

