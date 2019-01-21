using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorIntA = 4;
            int valorIntB;
            valorIntB = 1;

            int resultadoInt = valorIntA + valorIntB;
            Console.WriteLine(resultadoInt);
            
            float valorFloatA = 1;
            float valorFloatB = 3;
            float resultadoFloat = valorFloatA / valorFloatB;
            Console.WriteLine(resultadoFloat);

            double valorDoubleA = 1;
            double valorDoubleB = 3;
            double resultadoDouble = valorDoubleA / valorDoubleB;
            Console.WriteLine(resultadoDouble);

            Console.ReadLine();
        }
    }
}
