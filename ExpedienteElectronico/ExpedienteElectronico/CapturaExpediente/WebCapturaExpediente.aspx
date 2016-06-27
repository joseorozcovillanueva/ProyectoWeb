<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCapturaExpediente.aspx.cs" Inherits="ExpedienteElectronico.CapturaExpediente.WebCapturaExpediente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <script src="../scripts/jquery.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
    <link href="../Content/css/jquery.guillotine.css" rel="stylesheet" />
    <script src="../scripts/ajax.js"></script>
    <script src="../scripts/jquery.min.js"></script>
    <script src="../scripts/jquery-1.11.0.min.js"></script>
    <script src="../scripts/jquery.guillotine.js"></script>
    <link href="../Content/css/cssbotonesvisor.css" rel="stylesheet" />
    <script src="../scripts/jspdf.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
          <div class="jumbotron">
            <h1>Gráfica y avisos</h1>
            <p>Resize this responsive page to see the effect!</p>
          </div>
          <div class="row">
            <div class="col-sm-4">
              <div id="imagen" style="width:55%;max-height:75">
                   <img id="imgbase" style="width:380px;" />
              </div>
              <br/>
              <div id='controls'>
                  <asp:Button ID="rotate_left" CssClass="izquierda" ToolTip="Girar a la izquieda"   runat="server" OnClick="rotate_left_Click"/>               
                  <asp:Button ID="zoom_out" CssClass="menos" runat="server" ToolTip="Alejar Imagen" />
                  <asp:Button ID="fit" CssClass="centrar" runat="server" ToolTip="Ajustar Imagen" OnClick="fit_Click" />
                  <asp:Button ID="zoom_in" CssClass="cerca" runat="server" ToolTip="Acercar Imagen" />
                  <asp:Button id="rotate_right" CssClass="derecha" runat="server" ToolTip="Girar a la derecha" />
                  <asp:Button ID="imprimir" CssClass="imprimir" runat="server" ToolTip="Imprimir" />
                  
              </div>                 
            </div>            
            <div class="col-sm-4">
              <h3>Column 3</h3>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
              <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
            </div>
          </div>
        </div>
    </form>
    <script  type="text/javascript">
        function imprime(cRutaImagen) {
            var img = new Image();
            img.src = cRutaImagen;
            var doc = new jsPDF();
            doc.setFontSize(40);
            //			doc.text(35, 25, "Folio del Predio");
            doc.addImage(img, 'JPEG', 3, 10, 200, 250, 180, 230);
            //    doc.addImage(img, 'JPEG', 10, 50);
            doc.output('dataurlnewwindow', {})
            //doc.save('Prueba.pdf');		
        }


        jQuery(function () {
            var picture = $('#imgbase');
            picture.one('load', function () {
                picture.guillotine({ eventOnChange: 'guillotinechange' });
                var data = picture.guillotine('getData');
                for (var key in data) { $('#' + key).html(data[key]); }

                // Bind button actions
                $('#rotate_left').click(function () { picture.guillotine('rotateLeft'); });
                $('#rotate_right').click(function () { picture.guillotine('rotateRight'); });
                $('#fit').click(function () { picture.guillotine('fit'); });
                $('#zoom_in').click(function () { picture.guillotine('zoomIn'); });
                $('#zoom_out').click(function () { picture.guillotine('zoomOut'); });
                $('#imprimir').click(function () { imprime(document.getElementById("imgbase").src); });

                // Update data on change
                picture.on('guillotinechange', function (ev, data, action) {
                    data.scale = parseFloat(data.scale.toFixed(4));
                    for (var k in data) { $('#' + k).html(data[k]); }
                });
            });

            if (picture.prop('complete')) picture.trigger('load')
        });
      
        window.onload = function () {
            /* Aquí la instancia a eventos desde elementos que ya
               están cargados dentro de la página */
            $('#fit').trigger('click');

        }
    </script>
</body>
</html>
