using System;
namespace Aula10
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //CALCULADORA

            Console.WriteLine("==================CALCULADORA DE SWITCH==================");
            Console.WriteLine("Para que possamos calcular informe os valores");
            Console.WriteLine("informe o primeiro valor");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe o segundo valor");
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

            switch (operation)
            {
                case 1:
                   result = num1 + num2;
                break;

                case 2:
                   result = num1 - num2;
                break;

                case 3:
                   result = num1 * num2;
                break;

                case 4:
                    if (num2 != 0)
                    {
                       result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Não se divide por zero");
                    }

                break;
            }

            Console.WriteLine("Total: " + result);
        }
    }
}