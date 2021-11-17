using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 e 60 caracteres!")]
        [Display(Name = "Título")]

        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data de Lançamento em formato incorreto!")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório!")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido!")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!"), Required(ErrorMessage = "O campo genero é requerido!")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000!")]
        [Required(ErrorMessage = "Prrencha o campo Valor!")]
        [Column(TypeName = "decimal (18,2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "Prrencha o campo Avaliação!")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente Números de 1 - 5")]
        public int Avaliacao { get; set; }
    }
}
