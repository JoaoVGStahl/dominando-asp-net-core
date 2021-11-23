using Jdev.UI.AppModelo.Data;
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

        private readonly MeuDbContext _context;

        public TesteCrudController(MeuDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "João",
                DataNascimento = DateTime.Now,
                Email = "contato@jdev.com"
            };
            //Adiciona Aluno
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            //Pesquisa atraves do ID
            var aluno2 = _context.Alunos.Find(aluno.Id); 

            //Pesquisa Através do Email, porem retorna apenas o primeiro registro encontrado
            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "contato@jdev.com"); 

            //Pesquisa através do nome, porem retorna todos os registros encontrados
            var aluno4 = _context.Alunos.Where(a => a.Nome == "João");

            //Atualiza Registros
            aluno.Nome = "José";
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            //Remove Registro
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return View("_Layout");
        }
    }
}
