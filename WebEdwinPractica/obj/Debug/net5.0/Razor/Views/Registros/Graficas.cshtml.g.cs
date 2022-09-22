#pragma checksum "C:\Edwin_Ayala\WebEdwinPractica\WebEdwinPractica\Views\Registros\Graficas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8a32ed780d968dac9b81864414b2ebec984367"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registros_Graficas), @"mvc.1.0.view", @"/Views/Registros/Graficas.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Edwin_Ayala\WebEdwinPractica\WebEdwinPractica\Views\_ViewImports.cshtml"
using WebEdwinPractica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Edwin_Ayala\WebEdwinPractica\WebEdwinPractica\Views\_ViewImports.cshtml"
using WebEdwinPractica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8a32ed780d968dac9b81864414b2ebec984367", @"/Views/Registros/Graficas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c615a7df8a1d893969df99bafc045b2f15b3d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Registros_Graficas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebEdwinPractica.Models.Registros>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""content-wrapper"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <!-- AREA CHART -->
                    <div class=""card card-primary"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Área Chart</h3>
                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                    <i class=""fas fa-minus""></i>
                                </button>
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                    <i class=""fas fa-times""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div clas");
            WriteLiteral(@"s=""chart"">
                                <canvas id=""areaChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width:100%;""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <!-- PIE CHART -->
                    <div class=""card card-danger"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Gráfico Circular</h3>
                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                    <i class=""fas fa-minus""></i>
                                </button>
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                    <i class=""fas fa-times""></i");
            WriteLiteral(@">
                                </button>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""chart"">
                                <canvas id=""pieChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width:100%;""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <!-- BAR CHART -->
                    <div class=""card card-success"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Gráfico de Barras</h3>
                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                               ");
            WriteLiteral(@"     <i class=""fas fa-minus""></i>
                                </button>
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                    <i class=""fas fa-times""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""chart"">
                                <canvas id=""barChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width:100%;""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""form-group"">
                    <!-- LINE CHART -->
                    <div class=""card card-info"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Line Chart</h3>");
            WriteLiteral(@"
                            <div class=""card-tools"">
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                    <i class=""fas fa-minus""></i>
                                </button>
                                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                    <i class=""fas fa-times""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""chart"">
                                <canvas id=""lineChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width:100%;""></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        jQuery.ajax({\r\n                url: \'");
#nullable restore
#line 289 "C:\Edwin_Ayala\WebEdwinPractica\WebEdwinPractica\Views\Registros\Graficas.cshtml"
                 Write(Url.Action("DatosPersonas", "Registros"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: ""GET"",
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8"",
                success: function (data) {

                    /*console.log(data);*/

                    var arrayNombres = [];
                    var arrayEdades = [];

                    for (var i = 0; i < data.length; i++) {

                        /*console.log(data[i].mes)*/
                        arrayNombres.push(data[i].nombre)
                        arrayEdades.push(data[i].edad)
                    }


                    var controlPie1 = document.getElementById(""pieChart"");
                    var graficoPie1 = new Chart(controlPie1, {
                        type: 'pie',
                        data: {
                            labels: arrayNombres,
                            datasets: [{
                                data: arrayEdades,
                                backgroundColor: [""#03B100"", ""#0083B1"", ""#0800B1"", ""#f56954"", ");
                WriteLiteral(@"'#00a65a', '#f39c12', '#00c0ef', '#3c8dbc', '#d2d6de', '#007bff', '#dc3545', '#ffc107', '#28a745'],
                            }],
                        },
                        options: {
                            title: {
                                display: true,
                                fontSize: 26,
                                text: 'Reporte de edades'
                            }
                        }
                    });


                    var ctx = document.getElementById(""areaChart"").getContext('2d');
                    var myChart = new Chart(ctx, {
                        type: 'line',
                        //height: ""230px"",
                        //width: ""300px"",
                        responsive: false,
                        animation: false,
                        legend: { position: 'bottom' },
                        data: {
                            labels: arrayNombres,
                            datasets: [{
             ");
                WriteLiteral(@"                   label: 'Edad',
                                data: arrayEdades,
                                backgroundColor: ""rgb(66, 134, 244)""
                            }]
                        }, options: {
                            events: ['click'],
                            scaleShowValues: true,
                            scales: {
                                yAxes: [{
                                    ticks: {
                                        beginAtZero: true
                                    }
                                }],
                                xAxes: [{
                                    ticks: {
                                        autoSkip: false
                                    }
                                }]
                            },
                            title: {
                                display: true,
                                fontSize: 26,
                                text: 'Reporte ");
                WriteLiteral(@"de edades'
                            }
                        }
                    });

                    var ctx = document.getElementById(""lineChart"");
                    var chart = new Chart(ctx, {
                        type: ""line"",
                        data: {
                            labels: arrayNombres,
                            datasets: [{
                                label: ""Edad"",
                                fill: false,
                                backgroundColor: 'rgba(255,165,0,0.3)',
                                borderColor: 'rgb(255,135,20)',
                                pointStyle: ""circle"",
                                pointBackgroundColor: 'rgb(0,222,0)',
                                pointRadius: 5,
                                pointHoverRadius: 10,
                                data: arrayEdades
                            }]
                        },
                        options: {
                            respon");
                WriteLiteral(@"sive: true,
                            title: {
                                display: true,
                                fontSize: 26,
                                text: 'Reporte de edades'
                            },
                            tooltips: {
                                mode: 'point',
                                intersect: true,
                            },
                            hover: {
                                mode: 'nearest',
                                intersect: true
                            },
                            scales: {
                                xAxes: [{
                                    display: true,
                                    scaleLabel: {
                                        display: true,
                                        labelString: 'Nombres',
                                        fontSize: 15
                                    },
                                    ticks: {
 ");
                WriteLiteral(@"                                       fontSize: 15
                                    }
                                }],
                                yAxes: [{
                                    display: true,
                                    scaleLabel: {
                                        display: true,
                                        labelString: 'Edades)',
                                        fontSize: 15
                                    },
                                    ticks: {
                                        fontSize: 15
                                    }
                                }]
                            },
                            animation: {
                                duration: 2000
                            }
                        }
                    });

                    var controlBar1 = document.getElementById(""barChart"");
                    var graficoBar1 = new Chart(controlBar1, {
            ");
                WriteLiteral(@"            type: 'bar',
                        data: {
                            labels: arrayNombres,
                            datasets: [{
                                label: ""Edad"",
                                /*backgroundColor: ""#0800B1"",*/
                                backgroundColor: [""#03B100"", ""#0083B1"", ""#0800B1"", ""#f56954"", '#00a65a', '#f39c12', '#00c0ef', '#3c8dbc', '#d2d6de', '#007bff', '#dc3545', '#ffc107', '#28a745'],
                                borderColor: ""#000000"",
                                borderWidth: 0,
                                data: arrayEdades,
                            }],
                        },
                        options: {
                            scales: {
                                xAxes: [{
                                    gridLines: {
                                        display: true
                                    },
                                }],
                                yAxes: [{
  ");
                WriteLiteral(@"                                  ticks: {
                                        min: 0,
                                    },
                                    gridLines: {
                                        display: true
                                    }
                                }],
                            },
                            legend: {
                                display: true
                            },
                            title: {
                                display: true,
                                fontSize: 26,
                                text: 'Reporte de edades'
                            }
                        }
                    });
                },
                error: function (error) {
                    console.log(error)
                }
        });





    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebEdwinPractica.Models.Registros>> Html { get; private set; }
    }
}
#pragma warning restore 1591
