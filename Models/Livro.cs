using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int Quantidade { get; set; }
        public bool Lido { get; set; } // True para lido, False para não lido
        public DateTime DataDeRegistro { get; set; }
    }
}
