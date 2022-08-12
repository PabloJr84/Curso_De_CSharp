using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mao_Na_Massa06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicional");
            
            int idade = 17;
            int acompanhado = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo ");

            }
            else
            {
                if (acompanhado >= 3)
                    {
                    Console.WriteLine("Você não tem 18 anos,mas pode entrar, pois esta acompanhado ");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }
            }
            Console.ReadLine();
        }
    }
}
