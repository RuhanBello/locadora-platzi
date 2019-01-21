using System;
using System.Collections.Generic;

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

        public Filme(string nome, int anoLancamento, string genero, float avaliacao, int quantidade, bool lancamento)
        {
            this.nome = nome;
            this.anoLancamento = anoLancamento;
            this.genero = genero;
            this.avaliacao = avaliacao;
            this.quantidade = quantidade;
            this.lancamento = lancamento;
        }
    }

    class Program
    {
        public static Filme[] filmes = new Filme[3];
        public static Cliente[] clientes = new Cliente[2];

        static void Main(string[] args)
        {
            InicializarFilmes();
            InicializarClientes();

            int clienteLogadoID = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(clientes[clienteLogadoID].Nome + ", seja bem vindo(a) à locadora de filmes Platzi!");
                Console.WriteLine("O seu filme alugado é: " + clientes[clienteLogadoID].filmeAlugado.nome);

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Listar todos os filmes");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("\n");

                int escolha = 0;
                Int32.TryParse(Console.ReadLine(), out escolha);
                switch (escolha)
                {
                    case 1:
                        ListarFilmes();
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

        private static void InicializarFilmes()
        {
            filmes[0] = new Filme("Matrix", 1999, "Ação", 9.5f, 5, false);
            filmes[1] = new Filme("Matrix Reloaded", 2003, "Ação", 8f, 10, false);
            filmes[2] = new Filme("Matrix Revolutions", 2003, "Ação", 6f, 20, false);
        }

        private static void InicializarClientes()
        {
            clientes[0] = new Cliente("Ruhan", "ruhan", "123");
            clientes[1] = new Cliente("Paula", "paula", "456");
        }

        private static void ListarFilmes()
        {
            Console.Clear();
            Console.WriteLine("Listar todos os filmes");
            Console.WriteLine("\n");

            for (int i = 0; i < filmes.Length; i++)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Nome: " + filmes[i].nome);
                Console.WriteLine("Ano de lançamento: " + filmes[i].anoLancamento);
                Console.WriteLine("Gênero: " + filmes[i].genero);
                Console.WriteLine("Avaliação: " + filmes[i].avaliacao);
                Console.WriteLine("Quantidade: " + filmes[i].quantidade);
                Console.WriteLine("É lançamento: " + filmes[i].lancamento);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("Pressione qualquer botão para retornar.");
            Console.ReadLine();
        }
    }
}
