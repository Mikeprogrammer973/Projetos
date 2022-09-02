var code = " ";
var txt, proccess, xmlHttpRequest;

window.onload = function(){
    document.getElementById("encode").onclick = function(){
        proccess = 0;
        //document.getElementById("btn").style.display="none";
    }
    document.getElementById("decode").onclick = function(){
        proccess = 1;
        //document.getElementById("btn").style.display="block";
    }
    var obj = document.getElementById("txt")
    obj.addEventListener("input", function(){
        txt = obj.value;
        processo_cd();
    });

    //document.getElementById("btn").onclick = processo_cd();

    function processo_cd()
    {
        if(window.XMLHttpRequest)
        {
            xmlHttpRequest = new XMLHttpRequest();
        }
        else
        {
            xmlHttpRequest = new ActiveXObject();
        }
        if(proccess == 0)
        {//Processo CIFRAR
            var str = Array.from(txt);
            for(var c = 0; c < str.length; c++)
            {
                xmlHttpRequest.open("POST", `proccess_code.php?tipo=c&txt=${str[c]}`, true);
                xmlHttpRequest.send();
            }

            xmlHttpRequest.onreadystatechange = function(){
                if(xmlHttpRequest.readyState == 4 && xmlHttpRequest.status == 200)
                {
                    code += xmlHttpRequest.responseText + " ";
                    document.getElementById("code").innerHTML = " ";
                    document.getElementById("code").innerHTML = code;
                }
            }
        }
        else
        {//Processo DECIFRAR
            code = "";
            txt = obj.value;
            xmlHttpRequest.open("POST", `proccess_code.php?tipo=1&txt=${txt}`, true);
            xmlHttpRequest.send();
            xmlHttpRequest.onreadystatechange = function(){
                if(xmlHttpRequest.readyState == 4 && xmlHttpRequest.status == 200)
                {
                    document.getElementById("code").innerHTML = " ";
                    document.getElementById("code").innerHTML += xmlHttpRequest.responseText;
                }
        }
    }

    document.getElementById("clear").onclick = function(){
        code = "";
        document.getElementById("code").innerHTML = code;
        document.getElementById("txt").value = code;
    }
}
}