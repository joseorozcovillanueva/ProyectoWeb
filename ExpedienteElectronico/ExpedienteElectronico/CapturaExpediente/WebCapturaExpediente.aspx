<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCapturaExpediente.aspx.cs" Inherits="ExpedienteElectronico.CapturaExpediente.WebCapturaExpediente" %>

<!doctype html>
<html>
   <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Captura de Expediente</title>

    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <script src="../scripts/jquery.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
    <link href="../Content/css/jquery.guillotine.css" rel="stylesheet" />
    <script src="../scripts/ajax.js"></script>
    <script src="../scripts/jquery.min.js"></script>
    <script src="../scripts/jquery-1.11.0.min.js"></script>
    <script src="../scripts/jquery.guillotine.js"></script>
    <link href="../Content/css/cssbotonesvisor.css" rel="stylesheet" />
    <script src="../scripts/Chart.bundle.js"></script>
    <script src="../scripts/Chart.bundle.min.js"></script>
    <script src="../scripts/Chart.js"></script>
    <script src="../scripts/Chart.min.js"></script>    
    <script src="../scripts/jspdf.min.js"></script>
    <style>
    canvas {
        -moz-user-select: none;
        -webkit-user-select: none;
        -ms-user-select: none;
    }
    </style>
    
</head>

<body>  
     <form id="form1" runat="server">         

     <div >
          <div>   
             <div class="row" >
                 <div class="col-sm-4">
                   <div id="container" style="width:75%">
                        <canvas id="chart-area"> </canvas>
                   </div>                       
                </div>
                 <div class="col-sm-4">    
                     <p>mensajes</p>
                </div>
                  <div class="col-sm-4">    
                      <p>mensajes</p>
                </div>             
              </div>
          </div>
          <div class="row">
            <div class="col-sm-4" >
              <div id="imagen" style="width:auto; height:auto">
                   <asp:Image ID="imagen1" runat ="server" />                   
              </div>              
              <div id='controls'>
                  <button id='rotate_left'  type='button' class='izquierda' title='Girar a la Izquierda'>  </button>
                  <button id='zoom_out'     type='button' class='menos'     title='Alejar Imagen'>         </button>
                  <button id='fit'          type='button' class='centrar'   title='Ajustar Imagen'>        </button>
                  <button id='zoom_in'      type='button' class='cerca'     title='Acercar Imagen'>        </button>
                  <button id='rotate_right' type='button' class='derecha'   title='Girar a la Derecha'>    </button>
                  <button id='imprimir'     type='button' class='imprimir'   title='Imprimir'>   </button>                      
              </div>                 
            </div>        
            <div class="col-sm-4" >    
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
                        <img src="../img/cedulaCatastro.png" />                      
                    </div>

                    <div class="item">
                        <img src="../img/Manifiesto.png" />
                    </div>

                    <div class="item">
                        <img src="../img/plano.png" />
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
              <h4>Tipos de Archivo</h4>
              <p>Seleccionar el tipo de archivo requerido</p>              
            </div>
          </div>
        </div>

     </form>
     </body>
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

        $(document).ready(function () {
            $("#fit").trigger('click');
        });
            window.onload = function () {
                /* Aquí la instancia a eventos desde elementos que ya
                   están cargados dentro de la página */

                $(document).ready(function () {
                    $("#fit").trigger('click');
                });

            }
        

    </script>
     <script>
         var MONTHS = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];
         var randomScalingFactor = function () {
             return (Math.random() > 0.5 ? 1.0 : -1.0) * Math.round(Math.random() * 100);
         };
         var randomColorFactor = function () {
             return Math.round(Math.random() * 255);
         };
         var randomColor = function () {
             return 'rgba(' + randomColorFactor() + ',' + randomColorFactor() + ',' + randomColorFactor() + ',.7)';
         };
         var barChartData = {
             labels: ["Enero", "Febrero", "Marzo"],
             datasets: [{
                 label: 'Capturados',
                 backgroundColor: "rgba(220,220,220,0.5)",
                 data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor()]

             }]
         };

         window.onload = function () {
             var ctx = document.getElementById("chart-area").getContext("2d");
             window.myBar = new Chart(ctx, {
                 type: 'bar',
                 data: barChartData,
                 options: {
                     // Elements options apply to all of the options unless overridden in a dataset
                     // In this case, we are setting the border of each bar to be 2px wide and green
                     elements: {
                         rectangle: {
                             borderWidth: 2,
                             borderColor: 'rgb(0, 255, 0)',
                             borderSkipped: 'bottom'
                         }
                     },
                     responsive: true,
                     legend: {
                         position: 'top',
                     },
                     title: {
                         display: true,
                         text: 'Gráfica de Barra'
                     }
                 }
             });
         };
     </script>
</html>
