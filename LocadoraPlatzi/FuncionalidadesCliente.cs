using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class FuncionalidadesCliente
    {
        public static void ListarFilmes()
        {
            Console.Clear();
            Console.WriteLine("Listar todos os filmes");
            Console.WriteLine("\n");

            for (int i = 0; i < Program.filmes.Count; i++)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Nome: " + Program.filmes[i].nome);
                Console.WriteLine("Ano de lançamento: " + Program.filmes[i].anoLancamento);
                Console.WriteLine("Gênero: " + Program.filmes[i].genero);
                Console.WriteLine("Avaliação: " + Program.filmes[i].avaliacao);
                Console.WriteLine("Quantidade: " + Program.filmes[i].quantidade);
                Console.WriteLine("É lançamento: " + Program.filmes[i].lancamento);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("Pressione qualquer botão para retornar.");
            Console.ReadLine();
        }

        public static void ListarPorGenero()
        {
            Console.Clear();
            Console.Write("Digite o gênero do filme: ");
            string generoDoFilme = Console.ReadLine();

            for (int i = 0; i < Program.filmes.Count; i++)
            {
                if (Program.filmes[i].genero.ToString() == generoDoFilme)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("Nome: " + Program.filmes[i].nome);
                    Console.WriteLine("Ano de lançamento: " + Program.filmes[i].anoLancamento);
                    Console.WriteLine("Gênero: " + Program.filmes[i].genero);
                    Console.WriteLine("Avaliação: " + Program.filmes[i].avaliacao);
                    Console.WriteLine("Quantidade: " + Program.filmes[i].quantidade);
                    Console.WriteLine("É lançamento: " + Program.filmes[i].lancamento);
                    Console.WriteLine("---------------");
                }
            }

            Console.WriteLine("Pressione qualquer botão para retornar.");
            Console.ReadLine();
        }

        public static void AlugarFilme()
        {
            Console.Clear();
            Console.Write("Digite o nome do filme: ");
            string nomeDoFilme = Console.ReadLine();

            Cliente clienteLogado = Program.usuarioLogado as Cliente;

            for (int i = 0; i < Program.filmes.Count; i++)
            {
                if (Program.filmes[i].nome == nomeDoFilme)
                {
                    if (clienteLogado.filmeAlugado != null)
                    {
                        clienteLogado.filmeAlugado.quantidade++;
                    }

                    clienteLogado.filmeAlugado = Program.filmes[i];
                    Program.filmes[i].quantidade--;

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
