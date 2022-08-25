using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebEdwinPractica.Models;
using ClosedXML.Excel;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebEdwinPractica.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly string cadenaSql;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IConfiguration config)
        {
            cadenaSql = config.GetConnectionString("DefaultConnection");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult ExportarExcel()
        {
            DataTable tablaregistros = new DataTable();

            using (var conexion = new SqlConnection(cadenaSql))
            {
                conexion.Open();
                using (var adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand("sp_reporte_registros2", conexion);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(tablaregistros);
                }

                using (var libro = new XLWorkbook())
                {
                    tablaregistros.TableName = "Registros";
                    var hoja = libro.Worksheets.Add(tablaregistros);

                    hoja.ColumnsUsed().AdjustToContents();

                    using (var memoria = new MemoryStream())
                    {
                        libro.SaveAs(memoria);
                        var nombreExcel = string.Concat("Reporte registros", DateTime.Now.ToString(), ".xlsx");
                        return File(memoria.ToArray(), "aplication/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nombreExcel);

                    }
                }

                //return View();
            }

        }
    }
}