using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMySQL.Models;

namespace TestMySQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();

            //var cliente = new Cliente();
            //cliente.Nome = "Fernando Ferreira";
            //cliente.Email = "fernandofsan@gmail.com";

            //db.Clientes.Add(cliente);
            //db.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}