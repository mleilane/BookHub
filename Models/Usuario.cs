using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Models
{
    /// <summary>
    /// Representa um usuário no sistema, contendo as propriedades (ID, nome, login, senha e data de criação).
    /// </summary>
    
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
