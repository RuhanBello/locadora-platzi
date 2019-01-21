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
            bool deveSomar = true;
            int numeroA = 4;
            int numeroB = 6;
            int resultado;

            if (deveSomar)
            {
                resultado = numeroA + numeroB;
            } else
            {
                resultado = numeroA - numeroB;
            }

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
