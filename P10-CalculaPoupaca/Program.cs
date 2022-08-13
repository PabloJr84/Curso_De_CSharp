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
            int contadorMes = 1;

            while (contadorMes <= 12)
            {



                //0.36% = 0.0036
                valorinvestido = valorinvestido + valorinvestido * 0.0036;
                Console.WriteLine("Após "  + contadorMes+ " mês, você terá R$ " + valorinvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;

            }
            
            
            
            
            Console.ReadLine();
        }
    }
}
