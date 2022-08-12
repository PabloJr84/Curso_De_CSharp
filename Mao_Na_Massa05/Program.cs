using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mao_Na_Massa05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saudacao = "Olá meu nome é ";
            string nome = "Pablo";
            string continuacao = " e minha idade é ";
            int idade = 37;


            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.WriteLine("Aperte Enter para Sair");
            Console.ReadLine();
        }
    }
}
