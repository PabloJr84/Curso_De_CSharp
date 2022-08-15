using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <12; contadorMes = contadorMes + 1)
            {
                valorInvestido = valorInvestido + valorInvestido * 1.0036;
                Console.WriteLine("Após" + contadorMes + " meses, você terá R$" + valorInvestido);
            }


            Console.WriteLine("Aperte Enter Para Continuar");
            Console.ReadLine();
        }
    }
}
