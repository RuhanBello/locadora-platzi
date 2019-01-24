using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class Cliente : Usuario
    {
        public Filme filmeAlugado;

        public Cliente(string nome, string login, string senha) : base(nome, login, senha)
        {
        }

        public override void ExibirTela()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cliente(a) " + Nome + ", seja bem vindo(a) à locadora de filmes Platzi!");

                if (filmeAlugado != null)
                    Console.WriteLine("O seu filme alugado é: " + filmeAlugado.nome);

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Listar todos os filmes");
                Console.WriteLine("2 - Listar filmes por gênero");
                Console.WriteLine("3 - Alugar filme");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("\n");

                int escolha = 0;
                Int32.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        FuncionalidadesCliente.ListarFilmes();
                        break;
                    case 2:
                        FuncionalidadesCliente.ListarPorGenero();
                        break;
                    case 3:
                        FuncionalidadesCliente.AlugarFilme();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Obrigado por nos visitar!");
                        Console.ReadLine();
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
