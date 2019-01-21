using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class Administrador : Usuario
    {
        public Administrador(string nome, string login, string senha) : base(nome, login, senha)
        {
        }
    }
}
