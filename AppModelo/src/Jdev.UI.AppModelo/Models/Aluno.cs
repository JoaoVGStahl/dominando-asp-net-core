using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jdev.UI.AppModelo.Models
{

    public class Aluno
    {
        public Aluno()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
