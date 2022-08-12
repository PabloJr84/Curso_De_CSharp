using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeSamuel =3;
            int acompanhado = 2;

            if (idadeSamuel >= 3)
            {
                Console.WriteLine(" Samuel possui mais de 3 anos de idade. Pode entrar .");
            }

            else
            {
                if (acompanhado >= 2)
                {
                    Console.WriteLine("Samuel não possui mais de 3 anos, mais esta companhado");
                }
                else
                {
                    Console.WriteLine("Samuel não possui mais de 4 não pode entrar");
                }
            }



            Console.ReadLine();


        }
    }
}
