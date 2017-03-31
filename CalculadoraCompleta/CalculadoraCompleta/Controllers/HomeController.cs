using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraCompleta.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //inicializar os dados a serem enviados para a view
            ViewBag.Visor = "0";
            return View();
        }
        // POST: Home
        [HttpPost]
        public ActionResult Index(string bt, string visor)
        {
            //determinar o conteudo do botao
            switch (bt)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (visor.Equals("0")) { visor = bt; }
                    else visor += bt;
                    break;

                case "+/-" :
                    //visor = Convert.ToDouble(visor) * -1 + "";
                    if (visor.StartsWith("-")) visor = visor.Replace("-", "");
                    else visor = "-" + visor;
                    break;
                case ",":
                    if (!visor.Contains(",")) visor += ",";
                    break;
                case "C":
                    visor = "0";
                    break;

            }

            // enviar dados para a view

            ViewBag.Visor = visor;
            return View();
        }
    }
}