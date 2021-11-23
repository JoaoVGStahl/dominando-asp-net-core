using Jdev.UI.AppModelo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdev.UI.AppModelo.Controllers
{
    public class TesteCrudController : Controller
    {
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "João",
                DataNascimento = DateTime.Now,
                Email = "contato@jdev.com"
            };

            return View();
        }
    }
}
