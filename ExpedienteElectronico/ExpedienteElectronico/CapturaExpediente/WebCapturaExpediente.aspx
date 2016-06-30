<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebCapturaExpediente.aspx.cs" Inherits="ExpedienteElectronico.CapturaExpediente.WebCapturaExpediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form id="form1" runat="server">
         <script  type="text/javascript">      
             
             function rotarIzquierda() {
                 jQuery(function () {
                     var picture = $('#imagen1');
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
             }

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
        

        window.onload = function () {
            /* Aquí la instancia a eventos desde elementos que ya
               están cargados dentro de la página */
            $('#fit').trigger('click');

        }
    </script>

<div class="container">
          <div class="jumbotron">
            <h1>Gráfica y avisos</h1>
            <p>Resize this responsive page to see the effect!</p>
          </div>
          <div class="row">
            <div class="col-sm-4" style="width=750px; height=750px">
              <div id="imagen">
                   <asp:Image ID="imagen1" runat ="server" Height="650px" Width="650px" />                   
              </div>
              <br/>
              <div id='controls'>
                  <button id='rotate_left'  type='button' class='izquierda' title='Girar a la Izquierda'>  </button>
                  <button id='zoom_out'     type='button' class='menos'     title='Alejar Imagen'>         </button>
                  <button id='fit'          type='button' class='centrar'   title='Ajustar Imagen'>        </button>
                  <button id='zoom_in'      type='button' class='cerca'     title='Acercar Imagen'>        </button>
                  <button id='rotate_right' type='button' class='derecha'   title='Girar a la Derecha'>    </button>
                  <button id='imprimir'     type='button' class='imprimir'   title='Imprimir'>   </button>   
                  <button type="button" class="btn btn-info btn-lg" onclick="rotarIzquierda()">rotar izquierda</button>  
                  
              </div>                 
            </div>        
            <div class="col-sm-4" style="width=20px; height=20px">    
            </div>
            <div class="col-sm-4">
                <div id="myCarousel" class="carousel slide" data-ride="carousel">
                  <!-- Indicators -->
                  <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                    <li data-target="#myCarousel" data-slide-to="3"></li>
                  </ol>

                  <!-- Wrapper for slides -->
                  <div class="carousel-inner" role="listbox">
                    <div class="item active">
                      <img src="../img/Archivo.png" alt="Chania">
                    </div>

                    <div class="item">
                      <img src="../img/centrar.png" alt="Chania">
                    </div>

                    <div class="item">
                      <img src="../img/cerca.png" alt="Flower">
                    </div>

                    <div class="item">
                      <img src="../img/der.png" alt="Flower">
                    </div>
                  </div>

                  <!-- Left and right controls -->
                  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                  </a>
                  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                  </a>
                </div>
              <h3>Column 3</h3>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
              <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
            </div>
          </div>
        </div>

     </form>
     
</asp:Content>
