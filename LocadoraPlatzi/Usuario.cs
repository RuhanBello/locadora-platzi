using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class Usuario
    {
        protected string nome;
        public string Nome { get { return nome; } }

        protected string login;
        public string Login { get { return login; } }

        protected string senha;
        public string Senha { get { return senha; } }

        public Usuario(string nome, string login, string senha)
        {
            this.nome = nome;
            this.login = login;
            this.senha = senha;
        }
    }
}
