using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto");

            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores ate 32 bits
            int salarioEnInteriro = (int)salario;
            
            Console.WriteLine(salarioEnInteriro);

            //O long é um variavel de 64 bits
            long idade = 13000000000000;
            Console.WriteLine(idade);  

            // O short é um tipo de variavel de 16 bits
            short quantidadedeProdutos = 15000;
           Console.WriteLine(quantidadedeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
