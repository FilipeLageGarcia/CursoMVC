using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; } // Todas as classes terão um Id, que serão as chaves primárias no banco de dados
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Descricao { get; set; }

        public List<Produto> produtos { get; set; }
    }
}
