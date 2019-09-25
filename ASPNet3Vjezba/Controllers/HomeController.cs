using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet3Vjezba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Dobrodosli() {

            return View();
        }
        [HttpPost]
        public ActionResult Dobrodosli(string x, string y)
        {
            ViewBag.ime = x;
            ViewBag.prezime = y;
            return View("Dobrodosli2");
        }
        [HttpGet]
        public ActionResult Zbroji() {

            return View();
        }
        [HttpPost]
        public ActionResult Zbroji(int a, int b) {
            ViewBag.zbroji = a + b;
            return View("Zbroji2");
        }

        [HttpGet]
        public ActionResult Oduzmi() {

            return View();
        }

        [HttpPost]
        public ActionResult Oduzmi(int c, int d) {

            ViewBag.oduzmi = c - d;

            return View("Oduzmi2");
        }
        [HttpGet]
        public ActionResult Pomnozi() {

            return View();

        }
        [HttpPost]
        public ActionResult Pomnozi(int e,int f) {

            ViewBag.pomnozi = e * f;
            return View("Pomnozi2");
        }
        [HttpGet]
        public ActionResult Podjeli() {
            return View();
        }
        [HttpPost]
        public ActionResult Podjeli(int g, int h) {

            ViewBag.podijeli = g / h;
            return View("Podjeli2");
        }
    }
}