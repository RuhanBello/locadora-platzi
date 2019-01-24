using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class FuncionalidadesAdministrador
    {
        public static void AdicionarFilme()
        {
            Console.Clear();
            Console.Write("Nome do filme: ");
            string nome = Console.ReadLine();

            Console.Write("\nAno de lançamento: ");
            int anoLancamento = Int32.Parse(Console.ReadLine());

            Console.Write("\nGenero do filme: ");
            Genero genero;
            Enum.TryParse(Console.ReadLine(), out genero);

            Console.Write("\nAvaliação: ");
            float avaliacao = float.Parse(Console.ReadLine());

            Console.Write("\nQuantidade: ");
            int quantidade = Int32.Parse(Console.ReadLine());

            Console.Write("\nLançamento: ");
            bool lancamento;
            string lancamentoString = Console.ReadLine();
            if(lancamentoString == "True")
            {
                lancamento = true;
            } else
            {
                lancamento = false;
            }

            Filme novoFilme = new Filme(nome, anoLancamento, genero, avaliacao, quantidade, lancamento);
            Program.filmes.Add(novoFilme);

            Console.WriteLine("Novo filme adicionado com sucesso. Prossiga para ver a lista completa.");
            Console.ReadLine();
            ListarFilmes();
        }

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
    }
}
