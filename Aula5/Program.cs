using System;
namespace Aula5
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //Estrutura de condição o DIABO DO IF

            Console.WriteLine("VERIFICADOR DE NUMERO PAR OU IMPAR");
            Console. WriteLine("Digite um numero que deseja verificar");
                int number = Convert.ToInt32(Console.ReadLine());
                int resultado = number % 2;



            if (resultado == 0)
            {
                Console.WriteLine("O numero digitado é par!");
            }
            else
            {
                Console.WriteLine("O numero digitado é impar!");
            }

        }
    }
}