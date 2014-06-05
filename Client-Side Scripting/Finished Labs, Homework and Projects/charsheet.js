function getNodeText(node) {
    var nodeText = "ERROR";
    if (node.text)
        nodeText=node.text;
    else if (node.textContent)
        nodeText=node.textContent;
    return nodeText;
}

function character(str) {
    xhr = XMLHttpRequest();
    xhr.onreadystatechange = function() {
    
        if (xhr.readyState == 4 && (xhr.status == 200 || xhr.status == 0)){
            var xml = xhr.responseXML;
            var control = document.getElementById("firstName");
            var name = xml.getElementsByTagName("first");
            if (name.length > 0){
                control.value = getNodeText(name[0]); 
            }
            var control = document.getElementById("lastName");
            var name = xml.getElementsByTagName("last");
            if (name.length > 0){
                control.value = getNodeText(name[0]); 
            }
            document.getElementById("age").innerHTML = getNodeText(xml.getElementsByTagName("age")[0]);
            document.getElementById("race").innerHTML = getNodeText(xml.getElementsByTagName("race")[0]);
            document.getElementById("gender").innerHTML = getNodeText(xml.getElementsByTagName("gender")[0]);
            document.getElementById("level").innerHTML = getNodeText(xml.getElementsByTagName("level")[0]);
            document.getElementById("occupation").innerHTML = getNodeText(xml.getElementsByTagName("occupation")[0]);
            document.getElementById("backgroundInfo").innerHTML = getNodeText(xml.getElementsByTagName("background")[0]);
            document.getElementById("strScore").innerHTML = getNodeText(xml.getElementsByTagName("strength")[0]);
            document.getElementById("dexScore").innerHTML = getNodeText(xml.getElementsByTagName("dexterity")[0]);
            document.getElementById("conScore").innerHTML = getNodeText(xml.getElementsByTagName("constitution")[0]);
            document.getElementById("intScore").innerHTML = getNodeText(xml.getElementsByTagName("intelligence")[0]);
            document.getElementById("wisScore").innerHTML = getNodeText(xml.getElementsByTagName("wisdom")[0]);
            document.getElementById("chaScore").innerHTML = getNodeText(xml.getElementsByTagName("charisma")[0]);
            document.getElementById("alignment").innerHTML = getNodeText(xml.getElementsByTagName("alignment")[0]);
            
            
            
            
            
        }
    }
    xhr.open("GET", "xml/" +str+ ".xml", true);
    xhr.send();
}
