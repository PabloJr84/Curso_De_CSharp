using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mao_Na_Massa04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mão na massa 04");

            float pontoFlutuante = 3.14f;

            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine("Valor total é:" + total);

            Console.ReadKey();

        }
    }
}
