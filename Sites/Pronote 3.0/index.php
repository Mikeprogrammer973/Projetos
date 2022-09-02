<?php
    unset($_COOKIE["ca"]);
    unset($_COOKIE["function"]);
    @$erro = $_REQUEST["error"];
    @$info = $_REQUEST["info"];
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="apple-touch-icon" sizes="180x180" href="./Favicon/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="32x32" href="./Favicon/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="./Favicon/favicon-16x16.png">
    <link rel="manifest" href="./Favicon/site.webmanifest">
    <link rel="stylesheet" href="./Bibliotèques/bootstrap/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="./Styles/default_.css">
    <link rel="stylesheet" href="./Styles/initia_l.css">
    <script src="./Js/default.js"></script>
    <script src="./Js/initia_l.js"></script>
    <title>Pronote</title>
    <style> 
        
    </style>
</head>
<body>
    <header>
    <img src="./Favicon/apple-touch-icon.png">
    </header>
    <?php require_once("./Globals/header.php"); ?>
    <main>
        <section id="menu">
            <hr>
            <abbr title="Downloads">                
                    <div class="item-menu">
                        <img src="./Images/desenho.PNG" class="img-item-menu">                    
                    </div>
                </abbr>
                <hr>
                <abbr title="Guia Completo">                
                    <div class="item-menu">
                        <img src="./Images/desenho.PNG" class="img-item-menu">                    
                    </div>
                </abbr>
                <hr>
                <abbr title="Contatos">                
                    <div class="item-menu">
                        <img src="./Images/desenho.PNG" class="img-item-menu">                    
                    </div>
                </abbr>
                <hr>
                <abbr title="Opina">                
                    <div class="item-menu">
                        <img src="./Images/desenho.PNG" class="img-item-menu">                    
                    </div>
                </abbr>
        </section>
        <section id="login-zone">
            <section id="f_login">
                <p id="spin-login">
                    <span class="spinner-border spinner-border-sm"></span> Entrando...
                </p>
                <p id="erro">Preencha os campos *!</p>
                <p><label for="pass">Senha*:</label><br><input type="password" placeholder="Sua senha..." id="pass" required></p>
                <p>
                    <label for="function">Função*:</label><br><select id="function">
                        <option>Administrador</option>
                        <option>Professor</option>
                        <option>Aluno</option>
                    </select>
                </p>                
                <p><button id="logar">Entrar</button></p>
                <p id="criar-conta">Criar Conta</p>
            </section>
            <section id="fcadastro">
                <div class="close" id="fc">X</div>
                <hr>
                <?php
                    if($erro == "existing_user")
                    {
                        print "<p onload='start_dispair_notice(0)' id='erro'>Usuário Existente!</p>";
                    }
                    else if($erro == "error_db")
                    {
                        print "<p onload='start_dispair_notice(0)' id='erro'>Falha no servidor, tente mais tarde!</p>";
                    }
                    else if($erro == "invalid_extension")
                    {
                        print "<p onload='start_dispair_notice(0)' id='erro'>Extensão de imagem inválida, imagens PNG!</p>";
                    }
                    else if($erro == "invalid_size")
                    {
                        print "<p onload='start_dispair_notice(0)' id='erro'>Tamanho imagem não pode ser maior que 2MB!</p>";
                    }
                    else if($erro == "move_img")
                    {
                        print "<p onload='start_dispair_notice(0)' id='erro'>Erro ao carregar a imagem, tente novamente!</p>";
                    }
                    if($info == "success")
                    {
                        print "<p onload='start_dispair_notice(1)' id='sucesso'>Cadastro realizado com sucesso!</p>";
                    }
                ?>
                <form action="./cadastrar.php" method="post" enctype="multipart/form-data" autocomplete>
                    <p>
                        <label for="img">Foto Perfil:</label><br>
                        <div id="vista-img-perfil">
                            <img src="" style="width:100%;height:100%;">
                        </div>
                        <input type="file" name="img" id="img" accept=".png" required>
                    </p>
                    <p>
                        <label for="nome">Nome Completo:</label><br>
                        <input type="text" name="nome" id="nome" required>
                    </p>
                    <p>
                        <label for="email">E-mail:</label><br>
                        <input type="email" name="email" id="email" required>
                    </p>
                    <p>
                        <label for="senha">Senha:</label><br>
                        <input type="password" name="senha" id="senha" required>
                    </p>
                    <p>
                        <input type="submit" id="cd" value="Cadastrar">
                    </p>
                </form>
            </section>
        </section>        
    </main>
    <footer>
        <?php require_once("./Globals/footer.php"); ?>
    </footer>
</body>
</html>
<script>
    if("<?php echo $erro; ?>" != "" || "<?php echo $info; ?>" != ""){
        document.getElementById("fcadastro").style.display="block";
    }
</script>