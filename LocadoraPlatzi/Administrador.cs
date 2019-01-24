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

        public override void ExibirTela()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Administrador(a) " + Nome + ", seja bem vindo(a) à locadora de filmes Platzi!");

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar filme");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("\n");

                int escolha = 0;
                Int32.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        FuncionalidadesAdministrador.AdicionarFilme();
                        break;
                    case 4:
                        Console.WriteLine("Logout efetuado com sucesso");
                        Console.ReadLine();
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
