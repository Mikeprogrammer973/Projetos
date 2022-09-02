<?php
require_once("../Classes/Banco.class.php");
@$img = Banco::Select("SELECT foto_perfil_adm FROM adms WHERE code_adm = '".$_COOKIE["ca"]."'");


if($_COOKIE["ca"] != ""):  ?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="../Js/default.js"></script>
    <script src="../Js/admin.js"></script>
    <link rel="stylesheet" href="../Styles/default_.css">
    <link rel="stylesheet" href="../Styles/adm.css">
    <title>Pronote Admin</title>
    <style> 
    </style>
</head>
<body>
    <header>
    <img src="../Favicon/apple-touch-icon.png">
    </header>
    <?php require_once("../Globals/header.php"); ?>
    <main>
        <section id="menu_main">
            <abbr title="Seja Premium"><div id="premuim" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Conta"><div class="menu-item_round" id="img_conta">
                <?php print "<img class='img-menu-item' id='img_conta' src='data:image/PNG; base64,".base64_encode($img[0]["foto_perfil_adm"])."'>";  ?>
            </div></abbr>
            <abbr title="Home"><div id="home" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Escolas"><div id="escolas" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Turmas"><div id="turmas" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Alunos"><div id="alunos" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Professores"><div id="profs" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Disciplinas"><div id="materias" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Notas"><div id="notas" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Mensagens"><div id="msgs" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Downloads"><div id="dloads" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Guia Completo"><div id="guia" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Opina"><div id="opina" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Conte-nos"><div id="conte" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Contactos"><div id="contatos" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Contribue"><div id="dar" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
            <abbr title="Info"><div id="info" class="menu-item_round">
                <img class='img-menu-item' src="../Images/desenho.PNG">
            </div></abbr>
        </section>
        <section id="gerencia">

            <section id="form_gerencia">

                <section id="f_home">
                    <h1>Bem-vindo ao Pronote Admin 3.7.9!</h1>
                    <img src="./Img´s/1646424599.jpg" atl="Imagem de Início" id="img_init">
                    <p>--TUTORIAL COMPLETO--</p>
                </section>

                <section id="f_escolas">
                    <div class="controle">
                        <span class="anterior" id="a-escola"><</span>
                        <span class="status" id="status-escolas">0/0</span>
                        <span class="proximo" id="p-escola">></span>
                    </div>
                    <div class="portada" id="img-escola">
                        <img class="img-portada" id="img-perfil-escola" src="../Images/desenho.PNG"><span class="titulo-portada" id="nome-portada-escola">Nome Escola</span><button class="show" onclick="if(this.innerHTML == 'Λ'){document.getElementById('info-escola').style.display='block';this.innerHTML='V';}else{document.getElementById('info-escola').style.display='none';this.innerHTML='Λ';}">Λ</button>
                    </div>
                    <div style="margin-top:30px;" class="info" id="info-escola">
                        <img class="img-info" src="">
                        <p>
                            <label for="code-escola">Código:</label><br>
                            <input type="text" id="code-escola" readonly>
                        </p>
                        <p>
                            <label for="nome-escola">Nome:</label><br>
                            <input type="text" id="nome-escola" readonly>
                        </p>
                        <p>
                            <label for="status-escola">Status:</label><br>
                            <input type="text" id="status-escola" readonly>
                        </p>
                        <p>
                            <label for="qtd-alunos-escola">N° Alunos:</label><br>
                            <input type="text" id="qtd-alunos-escola" readonly>
                        </p>
                        <p>
                            <label for="qtd-profs-escola">N° Professores:</label><br>
                            <input type="text" id="qtd-profs-escola" readonly>
                        </p>
                        <p>
                            <label for="qtd-mat-escola">N° Disciplinas:</label><br>
                            <input type="text" id="qtd-mat-escola" readonly>
                        </p>
                    </div>                    
                </section>

                <section class="add" id="add-escolas">
                    <div class="close" id="f_add-escola">X</div>
                    <p>
                        <label for="img-add-escola">Imagem de Perfil:</label><br>
                        <div class="img-vista" id="img-add-vista">
                            <img src="" style="width:100%;height:100%;">
                        </div>
                        <input type="file" class="img-add" id="img-add-escola" accept=".png" required>
                    </p>
                    <p>
                        <label for="code-add-escola">Código:</label><br>
                        <input type="text" id="nome-add-escola" required>
                    </p>
                    <p>
                        <label for="code-add-escola">Nome:</label><br>
                        <input type="text" id="nome-add-escola" required>
                    </p>
                    <p>
                        <button class="btn-add" id="add-escola">Adicionar</button> 
                    </p>
                </section>
            </section>
            <section id="menu_gerencia">
                <abbr title="Adicionar"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Transferir"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Editar"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Arquivar"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Remover"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Recuperação"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Atualizar"><div class="gerencia-menu-item_round"></div></abbr>
                <abbr title="Info"><div class="gerencia-menu-item_round"></div></abbr>
            </section>
        </section>
    </main>
    <footer>
    <?php require_once("../Globals/footer.php") ?>
    </footer>
</body>
</html>
<?php endif; ?>