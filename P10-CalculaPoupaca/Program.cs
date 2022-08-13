using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Caula Poupança");


            double valorinvestido = 1000;

            //0.36% = 0.0036
            valorinvestido = valorinvestido + valorinvestido * 0.0036;
            Console.WriteLine("Após 1 mês, você terá R$" + valorinvestido);
            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}
