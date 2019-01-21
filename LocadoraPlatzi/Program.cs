using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    struct Filme
    {
        public string nome;
        public int anoLancamento;
        public string genero;
        public float avaliacao;
        public int quantidade;
        public bool lancamento;
    }

    class Program
    {
        public static Filme[] filmes = new Filme[3];

        static void Main(string[] args)
        {
            
            filmes[0] = new Filme();
            filmes[0].nome = "Matrix";
            filmes[0].anoLancamento = 1999;
            filmes[0].genero = "Ação";
            filmes[0].avaliacao = 9.5f;
            filmes[0].quantidade = 5;
            filmes[0].lancamento = false;

            filmes[1] = new Filme();
            filmes[1].nome = "Matrix Reloaded";

            filmes[2] = new Filme();
            filmes[2].nome = "Matrix Revolutions";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo à locadora de filmes Platzi!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Listar todos os filmes");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("\n");

                int escolha = 0;
                Int32.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Listar todos os filmes");
                        Console.WriteLine("\n");

                        for (int i = 0; i < filmes.Length; i++)
                        {
                            Console.WriteLine(filmes[i].nome);
                        }

                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Obrigado por nos visitar!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
