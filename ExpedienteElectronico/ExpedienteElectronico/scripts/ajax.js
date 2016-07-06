function Carga(url){

var objeto;

if (window.XMLHttpRequest)
{
//Mozilla, Safari, etc
objeto = new XMLHttpRequest();
}
else if (window.ActiveXObject)
{
	//Nuestro querido IE
	try {
	objeto = new ActiveXObject("Msxml2.XMLHTTP");
	} catch (e) {
	try { //Version mas antigua
	objeto = new ActiveXObject("Microsoft.XMLHTTP");
	} catch (e) {}
	}
}
if (!objeto){
 alert("No ha sido posible crear un objeto de XMLHttpRequest, favor de actualizar su navegador");
}

//Cuando XMLHttpRequest cambie de estado, ejecutamos esta funcion
 objeto.open('GET', url, true) // indicamos con el método open la url a cargar de manera asíncrona
// objeto.setRequestHeader("Content-Type", "image/png");
 //objeto.setRequestHeader("Content-Type", "application/octet-stream");
/* objeto.setRequestHeader("Content-Type", "image/png");*/
/* objeto.setRequestHeader("Content-Type", "application/x-www-form-urlencoded"); 
 Content-type:image/jpeg*/
 
 objeto.onreadystatechange=function(){
   cargarobjeto(objeto)
 }
 objeto.send() // Enviamos los datos con el metodo send
}

function cargarobjeto(objeto){
 //alert("viendo objeto");	
 if (objeto.readyState == 4) { //si se ha cargado completamente
    //alert("entre a estado 4");
   /* document.getElementById(id).innerHTML = 'objeto.responseText'; 
    document.getElementById('imageFullScreen').src = "<img src='http://sigweb25.merida.gob.mx/tif/tmptiff/cargando.gif' align='center' /> Cargando..."; */
   var response = objeto.responseText; 
    if(response) {
	  //alert(response);
       $('#imgprocesando').hide("fast");
	   document.getElementById('imgbase').src = response;     
		/*document.getElementById("slider").innerHTML = "<img src=" + ctoken + csesion + ".jpg align='center' /> Cargado"; */
/*			
		document.getElementById("slider").setAttribute('src', 'data:image/png;base64,'+ response);
        document.getElementById("slider").innerHTML = '<img src="data:image/png;base64,' + response + '" />';	
		*/

/*	for (var responseText = objeto.responseText, responseTextLen = responseText.length, binary = "", i = 0; i < responseTextLen; ++i) {
		 binary += String.fromCharCode(responseText.charCodeAt(i) & 255)
	   }		
	   document.getElementById("slider").innerHTML =  "<img src=" + "'data:image/png;base64,'" + "btoa(binary)";*/
        /*document.getElementById("slider").innerHTML = response; 			*/
	}
 }
 else {//en caso contrario, mostramos un gif simulando una precarga
	
 }
	
}