window.onload = function()
{
    
    var info;
    var http;
    var atual = 0,total = 0;

    const fileSelector = document.getElementById("img-add-escola");
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
                    document.getElementById("img-add-vista").children[0].src = event.target.result;
                    console.log(event.target.result);
                });
                reader.readAsDataURL(file);
            });

    if(window.XMLHttpRequest)
    {
        http = new XMLHttpRequest();
    }
    else
    {
        http = new ActiveXObject();
    }
    var menu_items = 
    [
        document.getElementById("home"),
        document.getElementById("escolas"),
        document.getElementById("turmas"),
        document.getElementById("img_conta"),
        document.getElementById("alunos"),
        document.getElementById("profs"),
        document.getElementById("materias"),
        document.getElementById("notas"),
        document.getElementById("msgs"),
        document.getElementById("dloads"),
        document.getElementById("guia"),
        document.getElementById("opina"),
        document.getElementById("conte"),
        document.getElementById("dar"),
        document.getElementById("contatos"),
        document.getElementById("info"),
        document.getElementById("premuim")
    ];

    /*for(var i = 0; i < menu_items.length; i++)
    {
        menu_items[i].addEventListener("click",function(){select_item_menu(i)});
    }*/
    menu_items[0].addEventListener("click",function(){select_item_menu(0)});
    menu_items[1].addEventListener("click",function(){select_item_menu(1)});
    menu_items[2].addEventListener("click",function(){select_item_menu(2)});
    menu_items[3].addEventListener("click",function(){select_item_menu(3)});
    menu_items[4].addEventListener("click",function(){select_item_menu(4)});
    menu_items[5].addEventListener("click",function(){select_item_menu(5)});
    menu_items[6].addEventListener("click",function(){select_item_menu(6)});
    menu_items[7].addEventListener("click",function(){select_item_menu(7)});
    menu_items[8].addEventListener("click",function(){select_item_menu(8)});
    menu_items[9].addEventListener("click",function(){select_item_menu(9)});
    menu_items[10].addEventListener("click",function(){select_item_menu(10)});
    menu_items[11].addEventListener("click",function(){select_item_menu(11)});
    menu_items[12].addEventListener("click",function(){select_item_menu(12)});
    menu_items[13].addEventListener("click",function(){select_item_menu(13)});
    menu_items[14].addEventListener("click",function(){select_item_menu(14)});
    menu_items[15].addEventListener("click",function(){select_item_menu(15)});
    menu_items[16].addEventListener("click",function(){select_item_menu(16)});
    document.getElementById("a-escola").addEventListener("click",function(){anterior("escolas")});
    document.getElementById("p-escola").addEventListener("click",function(){proximo("escolas")});
    document.getElementById("f_add-escola").addEventListener("click",function(){document.getElementById("add-escolas").style.display="none";});

    var selected_item_menu = menu_items[0];
    select_item_menu(0);

   

    function select_item_menu(item)
    {
        document.getElementById(`f_${selected_item_menu.id}`).style.display="none";
        selected_item_menu.style.borderColor = "white";
        selected_item_menu = menu_items[item];
        selected_item_menu.style.borderColor = "rgb(142, 226, 142)";
        switch(item)
        {
            case 0:
            case 3:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
                document.getElementById("form_gerencia").style.width="100%";
                document.getElementById("menu_gerencia").style.display="none";
                document.getElementById(`f_${selected_item_menu.id}`).style.display="block";
                
                break;
            case 1:
            case 2:
            case 4:
            case 5:
            case 6:
            case 7:
                document.getElementById("form_gerencia").style.width="80%";
                document.getElementById("menu_gerencia").style.display="block";
                document.getElementById(`f_${selected_item_menu.id}`).style.display="block";

                http.open("POST",`./admin.php?categoria=${selected_item_menu.id}&tipo=info`);
                http.send();

                http.onreadystatechange = function()
                {
                    if(http.readyState == 4 && http.status == 200)
                    {
                        //.write(http.responseText);
                        info = JSON.parse(http.responseText);                        
                        console.log(info);
                        total = info.length;
                        if(total > 0)
                        {
                            atual = 1;
                        }
                        else
                        {
                            atual = 0;
                        }
                        document.getElementById(`status-${selected_item_menu.id}`).innerHTML = `${atual}/${total}`;
                        proximo("escolas");
                        window.addEventListener("keydown",function()
                        {
                            if(event.keyCode == 37)
                            {
                                anterior("escolas");
                            }
                            else if(event.keyCode == 39)
                            {
                                proximo("escolas");
                            }
                        });
                    }
                }
        }        
    }

    function preencher_dados(index,tipo)
    {
        switch(tipo)
        {
            case "escolas":
            document.getElementById("img-perfil-escola").src = `data:image/PNG; base64,${info[index-1][3]}`;
            document.getElementById("code-escola").value = `${info[index-1][0]}`;
            document.getElementById("nome-portada-escola").innerHTML = `${info[index-1][1]}`;
            document.getElementById("nome-escola").value = `${info[index-1][1]}`;
            document.getElementById("status-escola").value = "" + (info[index-1][2] == 'C' ? "Ativa" : "Arquivada") + "";
            document.getElementById("qtd-alunos-escola").value = `${info[index-1][4]}`;
            document.getElementById("qtd-profs-escola").value = `${info[index-1][5]}`;
            document.getElementById("qtd-mat-escola").value = `${info[index-1][6]}`;
        }
    }

    function proximo(tipo)
    {
        atual += 1;
        if(atual > total)
        {
            if(total > 0)
            {
                atual = 1;
                preencher_dados(atual,tipo);
                document.getElementById(`status-${selected_item_menu.id}`).innerHTML = `${atual}/${total}`;
            }
            else
            {
                atual = 0;
            }
            return;
        }
        preencher_dados(atual,tipo);
        document.getElementById(`status-${selected_item_menu.id}`).innerHTML = `${atual}/${total}`;
    }

    function anterior(tipo)
    {
        atual += -1;
        if(atual < 1)
        {
            if(total > 0)
            {
                atual = total;
                preencher_dados(atual,tipo);
                document.getElementById(`status-${selected_item_menu.id}`).innerHTML = `${atual}/${total}`;
            }
            else
            {
                atual = 0;
            }
            return;
        }
        preencher_dados(atual,tipo);
        document.getElementById(`status-${selected_item_menu.id}`).innerHTML = `${atual}/${total}`;
    }




}