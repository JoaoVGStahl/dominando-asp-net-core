﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var filme = new Filme {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };
            return RedirectToAction("Privacy", filme);

            //return View();
        }
 
        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var erro in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(erro.ErrorMessage);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
