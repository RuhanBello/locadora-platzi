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
            Console.WriteLine("Inteiros");

            int valorIntA = 3;
            int valorIntB = 2;
            int resultadoInt;

            resultadoInt = valorIntA + valorIntB;
            Console.WriteLine("Inteiros " + valorIntA + " + " + valorIntB + " = " + resultadoInt);

            resultadoInt = valorIntA - valorIntB;
            Console.WriteLine("\nInteiros " + valorIntA + " - " + valorIntB + " = " + resultadoInt);

            resultadoInt = valorIntA * valorIntB;
            Console.WriteLine("\nInteiros " + valorIntA + " * " + valorIntB + " = " + resultadoInt);

            resultadoInt = valorIntA / valorIntB;
            Console.WriteLine("\nInteiros " + valorIntA + " / " + valorIntB + " = " + resultadoInt);

            resultadoInt = valorIntA % valorIntB;
            Console.WriteLine("\nInteiros " + valorIntA + " % " + valorIntB + " = " + resultadoInt);

            resultadoInt = 0;
            resultadoInt++;
            Console.WriteLine("\nInteiro 0++ = " + resultadoInt);

            resultadoInt = 0;
            resultadoInt--;
            Console.WriteLine("\nInteiro 0-- = " + resultadoInt);

            resultadoInt = 0;
            resultadoInt += 5;
            Console.WriteLine("\nInteiro 0+=5 = " + resultadoInt);

            resultadoInt = 0;
            resultadoInt -= 5;
            Console.WriteLine("\nInteiro 0-=5 = " + resultadoInt);

            Console.Write("\n\nFloats");
            float valorFloatA = 1;
            float valorFloatB = 3;
            float resultadoFloat;

            resultadoFloat = valorFloatA * valorFloatB;
            Console.WriteLine("\nFloats " + valorFloatA + " * " + valorFloatB + " = " + resultadoFloat);

            resultadoFloat = valorFloatA / valorFloatB;
            Console.WriteLine("\nFloats " + valorFloatA + " / " + valorFloatB + " = " + resultadoFloat);

            Console.Write("\n\nDoubles");
            double valorDoubleA = 1;
            double valorDoubleB = 3;
            double resultadoDouble;

            resultadoDouble = valorDoubleA * valorDoubleB;
            Console.WriteLine("\nDoubles " + valorDoubleA + " * " + valorDoubleB + " = " + resultadoDouble);

            resultadoDouble = valorDoubleA / valorDoubleB;
            Console.WriteLine("\nDoubles " + valorDoubleA + " / " + valorDoubleB + " = " + resultadoDouble);

            Console.ReadLine();
        }
    }
}
