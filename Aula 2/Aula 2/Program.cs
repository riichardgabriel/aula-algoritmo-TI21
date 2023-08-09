using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int soma;
            int subtracao;
            int multiplicacao;
            int divisao;
            int resto;


            //Console.Write("Hello world");

            Console.Write("Digite 1º numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite 2º numero: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b; //Estamos somando os valores das variaveis a e b
            Console.WriteLine("A soma dos valores: " + soma);

            subtracao = a - b; //Estamos subtraindo os valores das variaveis a e b
            Console.WriteLine("A subtração dos valores :" + subtracao);

            multiplicacao = a * b; //Estamos multiplicando os valores das variaveis a e b
            Console.WriteLine("A multiplicação dos valores: " + multiplicacao);

            divisao = a / b; //Estamos dividindo os valores das variaveis a e b
            Console.WriteLine("A divisão dos valores: " + divisao);







            Console.ReadKey();


        }
    }
}
