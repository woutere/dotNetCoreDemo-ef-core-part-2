using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloCore.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "HelloWorld Index";
            return View();
        }

        public IActionResult Hallo(string naam, int aantal)
        {
            ViewData["Message"] = "Hallo " + naam;
            ViewData["Aantal"] = aantal;
            return View();
        }

        //public String Welkom()
        //{
        //    return "Dit is de welkom action method";
        //}

        //public String Bestelling(int id)
        //{
        //    return "Dit is de bestelling met id:" + id;
        //}

        //public String Boodschap(string voornaam, string boodschap)
        //{
        //    return "Boodschap van " + voornaam + " " + boodschap;
        //}
    }
}