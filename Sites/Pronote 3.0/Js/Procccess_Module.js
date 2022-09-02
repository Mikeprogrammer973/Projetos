export function Hello(msg)
{
    alert(msg);
}

export function exibir_menu()
{
    obj = document.getElementById("menu_itens");
        if(obj.style.display == "block")
        {
            obj.style.display = "none";            
        }
        else
        {
            obj.style.display = "block";
        }
}

export function setXMLvar()
{
    var xmlHttpRequest;
    if(window.XMLHttpRequest)
    {
        return xmlHttpRequest = new XMLHttpRequest();
    }
    else
    {
        return xmlHttpRequest = new ActiveXObject();
    }
}

export function sendRequest(xmlHttpRequest,file)
{
    xmlHttpRequest.open("POST",file);
    xmlHttpRequest.send();

    xmlHttpRequest.onreadystatechange = function()
    {
        if(xmlHttpRequest.readyState == 4 && xmlHttpRequest.status == 200)
        {
            return xmlHttpRequest.responseText;
        }
    }
}