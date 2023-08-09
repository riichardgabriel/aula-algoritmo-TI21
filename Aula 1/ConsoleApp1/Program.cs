using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World"); // console.write console para termos interações com o console e write serve para escrever no console
            //Console.ReadKey(); //Readkey le somente uma tecla

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma;


            Console.Write("Digite o 1º numero");
            //int.parse converte uma cadeia de caracter para o tipo INTEIRO
            numero1 = int.Parse (Console.ReadLine()); // le a sequencia de caracter digitado pelo o usuario
            //Estamos utilizando o sinal de + para concatenar o texto digitado + o valor da variavel "numero1"
            Console.WriteLine("O valor digitado foi: " + numero1);

            Console.Write("Digite o 2º numero");
            numero2 =int.Parse(Console.ReadLine());
            Console.Write("O 2º valor digitado foi: " + numero2);

            Console.Write("Digite o 3º numero");
            numero3= int.Parse(Console.ReadLine());
            Console.Write("O 3º valor digitado foi: " + numero3);

            Console.Write("Digite o 4º numero");
            numero4= int.Parse(Console.ReadLine());
            Console.Write("O 4º valoe digitado foi: " + numero4);


            soma = numero1 + numero2 + numero3 + numero4;

            Console.WriteLine("O valor total foi: " + soma);



            Console.ReadKey(); //Nesse momento o readkey serve para o nosso programa não fechar




        }
    }
}
