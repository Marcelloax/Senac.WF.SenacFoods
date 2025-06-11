using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacFoods
{
    public class Usuario
    {
        // criar as propriedades
        // id int,
        public int Id { get; set; }
        // nome string,
        public string Nome { get; set; }
        // email string, senha string,
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        // ativo bool,
    }
}
