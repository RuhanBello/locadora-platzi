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
        }
    }
}
