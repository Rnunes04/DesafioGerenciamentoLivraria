using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLivros.Aplicacao.DTOs
{
    public class LivrosDTO
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
    }
}
