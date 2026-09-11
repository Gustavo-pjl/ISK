using System;
namespace Aula9
{
    public class Program
    {
         public static void Main(string[] args)
        {
           bool varContinue = true;
           while (varContinue){
            //inicializaçõ do programa
           Console.WriteLine("\nCalculadora Simples");

           Console.WriteLine("Digite o primeiro numero");
           double num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite o segundo numero");
           double num2 = Convert.ToDouble(Console.ReadLine());

           //Selecionar o tipo de operação
            Console.WriteLine("\nEscolha a operação");
                //operações
            Console.WriteLine("1 - Adição (+): ");
            Console.WriteLine("2 - subtração (-): ");
            Console.WriteLine("3 - Multiplicação (+): ");
            Console.WriteLine("4 - Divisão (+): ");

            Console.WriteLine("Digite o numero da operação");
            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            //CONDIÇÕES

            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Não se divide por 0");
                }
            }
            else
            {
                Console.WriteLine("Operação Invalida");
            }

                Console.WriteLine("\n Resultado: " + result);


                Console.WriteLine("Deseja realizar outra operação (s/n)?");
                String resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    varContinue = false;
                Console.WriteLine("\n Obrigado por usar a calculadora " );    
                }
           }
        }
    }
}