using System;
namespace Aula4
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("===============CALCULADORA==============");

            Console.WriteLine("Digite o numero 1");
                int number1 = Convert.ToInt32(Console.ReadLine());               
            Console.WriteLine("Digite o numero 2");
                int number2 = Convert.ToInt32(Console.ReadLine());


            int sum = number1 + number2;
            int subtração = number1 - number2;
            float divisao = number2 / number1;
            float mult = number2 * number1;
            int modulo = number2 % number1;

            //RESULTADO

            Console.WriteLine("valor da soma: " + sum);
            Console.WriteLine("valor da subtração: " + subtração);
            Console.WriteLine("valor da divisão: " + divisao);
            Console.WriteLine("valor da multiplicação: " + mult);
            Console.WriteLine("valor da modulo: " + modulo);
        }
    }
}