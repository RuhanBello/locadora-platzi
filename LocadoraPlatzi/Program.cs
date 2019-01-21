using System;
using System.Collections.Generic;

namespace LocadoraPlatzi
{
    enum Genero { Acao, Terror, Comedia, Romance };

    class Filme
    {
        public string nome;
        public int anoLancamento;
        public Genero genero;
        public float avaliacao;
        public int quantidade;
        public bool lancamento;

        public Filme(string nome, int anoLancamento, Genero genero, float avaliacao, int quantidade, bool lancamento)
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
        private static List<Filme> filmes = new List<Filme>();
        private static List<Cliente> clientes = new List<Cliente>();
        private static int clienteLogadoID = 0;

        static void Main(string[] args)
        {
            InicializarFilmes();
            InicializarClientes();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(clientes[clienteLogadoID].Nome + ", seja bem vindo(a) à locadora de filmes Platzi!");

                if (clientes[clienteLogadoID].filmeAlugado != null)
                    Console.WriteLine("O seu filme alugado é: " + clientes[clienteLogadoID].filmeAlugado.nome);

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
                        ListarFilmes();
                        break;
                    case 2:
                        ListarPorGenero();
                        break;
                    case 3:
                        AlugarFilme();
                        break;
                    case 4:
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
            filmes.Add(new Filme("Matrix", 1999, Genero.Acao, 9.5f, 5, false));
            filmes.Add(new Filme("Matrix Reloaded", 2003, Genero.Acao, 8f, 10, false));
            filmes.Add(new Filme("Matrix Revolutions", 2003, Genero.Acao, 6f, 20, false));
            filmes.Add(new Filme("Ghost", 1990, Genero.Romance, 10f, 2, false));
        }

        private static void InicializarClientes()
        {
            clientes.Add(new Cliente("Ruhan", "ruhan", "123"));
            clientes.Add(new Cliente("Paula", "paula", "456"));
        }

        private static void ListarFilmes()
        {
            Console.Clear();
            Console.WriteLine("Listar todos os filmes");
            Console.WriteLine("\n");

            for (int i = 0; i < filmes.Count; i++)
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

        private static void ListarPorGenero()
        {
            Console.Clear();
            Console.Write("Digite o gênero do filme: ");
            string generoDoFilme = Console.ReadLine();

            for (int i = 0; i < filmes.Count; i++)
            {
                if (filmes[i].genero.ToString() == generoDoFilme)
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
            }

            Console.WriteLine("Pressione qualquer botão para retornar.");
            Console.ReadLine();
        }

        private static void AlugarFilme()
        {
            Console.Clear();
            Console.Write("Digite o nome do filme: ");
            string nomeDoFilme = Console.ReadLine();

            for (int i = 0; i < filmes.Count; i++)
            {
                if (filmes[i].nome == nomeDoFilme)
                {
                    if (clientes[clienteLogadoID].filmeAlugado != null)
                    {
                        clientes[clienteLogadoID].filmeAlugado.quantidade++;
                    }

                    clientes[clienteLogadoID].filmeAlugado = filmes[i];
                    filmes[i].quantidade--;

                    Console.Write("Filme alugado com sucesso!");
                    Console.ReadLine();
                    return;
                }
            }

            Console.Write("A locadora não possui o filme buscado.");
            Console.ReadLine();
        }
    }
}
