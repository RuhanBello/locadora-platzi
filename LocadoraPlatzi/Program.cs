using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            char caractere = 'O';
            Console.WriteLine(caractere);

            string frase = "\nStrings suportam frases inteiras";
            Console.WriteLine(frase);

            string fraseA = "\nAlem disso, suportam ";
            string fraseB = "concatenacao de strings";
            string resultado = fraseA + fraseB;
            Console.WriteLine(resultado);

            string fraseComPonto = "\nSuporta separar uma frase atraves de caracteres. Incrivel!";
            string parteA = fraseComPonto.Split('.')[0];
            string parteB = fraseComPonto.Split('.')[1];
            Console.WriteLine(parteA);
            Console.WriteLine(parteB);

            Console.WriteLine("\nPodemos concatenar aqui tambem. " + "Basta usar a soma.");

            string frasePequena = "Bom dia";
            int tamanhoFrase = frasePequena.Length;
            Console.WriteLine("\nPodemos saber a quantidade de caracteres contidos na string Bom Dia: " + tamanhoFrase);

            Console.ReadLine();
        }
    }
}
