using Highsoft.Web.Mvc.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [HandleError(View = "Error")]
        public ActionResult Index()
        {
            try
            {
                List<PieSeriesData> pieData = new List<PieSeriesData>();

                pieData.Add(new PieSeriesData() { Name = "PRI", Y = 10.00, Color = "#04B404" });
                pieData.Add(new PieSeriesData() { Name = "PAN", Y = 10.00, Color = "#2E64FE" });
                pieData.Add(new PieSeriesData() { Name = "PRD", Y = 10.00, Color = "#FFFF00" });
                pieData.Add(new PieSeriesData() { Name = "PT", Y = 10.00, Color = "#FF0000" });
                pieData.Add(new PieSeriesData() { Name = "Partido Verde", Y = 10.00, Color = "#64FE2E" });
                pieData.Add(new PieSeriesData() { Name = "Independiente", Y = 10.00, Color = "#8904B1" });

                ViewData["PartyPie"] = pieData;

                List<ColumnSeriesData> columnData = new List<ColumnSeriesData>();

                columnData.Add(new ColumnSeriesData() { Name = "Andres Manuel Lopez Obrador", Y = 10.00, Color = "#FF0000" });
                columnData.Add(new ColumnSeriesData() { Name = "Jose Antonio Meade Kuribreña", Y = 10.00, Color = "#04B404" });
                columnData.Add(new ColumnSeriesData() { Name = "Jaime Heliodoro Rodriguez Calderon", Y = 10.00, Color = "#8904B1" });
                columnData.Add(new ColumnSeriesData() { Name = "Ricardo Anaya Cortés", Y = 10.00, Color = "#2E64FE" });
                columnData.Add(new ColumnSeriesData() { Name = "Margarita Ester Zavala Gómez del Campo", Y = 10.00, Color = "#64FE2E" });

                ViewData["ColumnCandidate"] = columnData;
            }
            catch (Exception e)
            {
                throw new Excepcion(e.Message);
            }

            return View();
        }
    }
}