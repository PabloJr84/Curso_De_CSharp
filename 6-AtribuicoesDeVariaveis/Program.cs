using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6");

            int idade = 32;
            int idadePablo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadePablo);

            Console.ReadLine();
        }
    }
}
