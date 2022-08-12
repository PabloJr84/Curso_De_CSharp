using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra =(char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso de tecnologia " + 2022;
            string cursoProgramcao = @" -.net
 - Java
 - Javascript";

            Console.WriteLine(titulo); 
            Console.WriteLine(cursoProgramcao);


            Console.ReadLine();
        }
    }
}
