
        
        window.onload = function()
        {
            var opcaity = 100;
            var dispair_n;
            var tipo = null;

            //Usando Drag & Drop
            const drop_zone = document.getElementById("vista-img-perfil");
            drop_zone.addEventListener("dragover",(event) => {
                event.stopPropagation();
                event.preventDefault();
                //Setando o modo "copy file"
                event.dataTransfer.dropEffect = 'copy';
            });
            drop_zone.addEventListener("drop",(event) => {
                event.stopPropagation();
                event.preventDefault();
                //Obtem arquivo
                const fileList = event.dataTransfer.files;
                //Setando o flieList do input
                document.getElementById("img").files = event.dataTransfer.files;
                const file = fileList[0];
                console.log(file);
                //Lendo o arquivo
                const reader = new FileReader();
                reader.addEventListener("load",(event) => {
                    //Exibe a Imagem
                    document.getElementById("vista-img-perfil").children[0].src = event.target.result;
                    console.log(event.target.result);
                });
                reader.readAsDataURL(file);
            });

            const fileSelector = document.getElementById("img");
            fileSelector.addEventListener("change",(event) => {
                //Obtem o arquivo
                const fileList = event.target.files;
                const file = fileList[0];
                console.log(file);
                //Verifica se é uma imagem
                if(file.type && !file.type.startsWith('image/'))
                {
                    alert("Esse arquivo não é uma imagem!");
                    console.log("Esse arquivo não é uma imagem!");
                    return;
                }
                //Lendo o arquivo
                const reader = new FileReader();
                reader.addEventListener("load",(event) => {
                    //Exibe a Imagem
                    document.getElementById("vista-img-perfil").children[0].src = event.target.result;
                    console.log(event.target.result);
                });
                reader.readAsDataURL(file);
            });

            function start_dispair_notice(type){
                dispair_n = setInterval(dispair_notice,10);
                tipo = type;
            }

            function dispair_notice(){
                opcaity--;
                if(tipo == 0){
                    if(opcaity == 0){
                        document.getElementById("erro").style.display=`none`;
                        clearInterval(dispair_n);
                    }
                    document.getElementById("erro").style.opacity=`${opcaity}%`;
                }else if(tipo == 1){
                    if(opcaity == 0){
                        document.getElementById("sucesso").style.display=`none`;
                        clearInterval(dispair_n);
                    }
                    document.getElementById("sucesso").style.opacity=`${opcaity}%`;
                }else if(tipo == 2){
                    if(opcaity == 0){
                        document.getElementById("fcadastro").style.display="none";
                        clearInterval(dispair_n);
                    }
                    document.getElementById("fcadastro").style.opacity=`${opcaity}%`;
                }
            }

            document.getElementById("criar-conta").addEventListener("click",function()
            {
                document.getElementById("fcadastro").style.display="block";
                document.getElementById("fcadastro").style.opacity=`100%`;
            });
            document.getElementById("fc").addEventListener("click",function()
            {
                start_dispair_notice(2);
                opcaity = 100;
            });

            var select = document.getElementById("function");
            var funcao, senha, result;
            var xmlHttpRequest;
            if(window.XMLHttpRequest)
            {
                xmlHttpRequest = new XMLHttpRequest();
            }
            else
            {
                xmlHttpRequest = new ActiveXObject();
            }

            document.getElementById("logar").onclick = function()
            {
                document.getElementById("spin-login").style.display="block";
                setTimeout(function()
                {
                    document.getElementById("spin-login").style.display="none";
                    //Testar os campos
                   if(document.getElementById("pass").value == "")
                    {
                        document.getElementById("erro").style.display="block";
                        document.getElementById("erro").innerHTML="Senha Inválida!";
                        setTimeout(function(){document.getElementById("erro").style.display="none";},7000);
                    }
                    else
                    {
                        senha = document.getElementById("pass").value;
                        if(select.children[0].selected)
                        {
                            funcao = "adm";
                        }
                        else if(select.children[1].selected)
                        {
                            funcao = "prof";
                        }
                        else
                        {
                            funcao = "aluno";
                        }
                        //Mandar request pro login.php 
                        xmlHttpRequest.open("POST",`login.php?function=${funcao}&senha=${senha}`);
                        xmlHttpRequest.send();

                        xmlHttpRequest.onreadystatechange = function()
                        {
                            if(xmlHttpRequest.readyState == 4 && xmlHttpRequest.status == 200)
                            {
                                //Analisar resposta
                                if(xmlHttpRequest.responseText == "OK")
                                {
                                    switch(funcao)
                                    {
                                        case "adm":
                                            location.replace("./Admin/index.php");
                                            break;
                                        case "prof":
                                            location.replace("./Prof/index.php");
                                            break;
                                        case "aluno":
                                            location.replace("./Aluno/index.php");
                                            break;
                                    }
                                }
                                else if(xmlHttpRequest.responseText == "invalid_user")
                                {
                                    document.getElementById("erro").style.display="block";
                                    document.getElementById("erro").innerHTML="Senha/Função Incorreta!";
                                    setTimeout(function(){document.getElementById("erro").style.display="none";},7000);
                                }
                            }
                        }                    
                    }
                },5000);
            }
        }
    
      