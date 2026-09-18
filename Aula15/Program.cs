using System;
namespace Aula15
{
    public class Program
    {
         public static void Main(string[] args)
        {
            string separator = "-----------------";

        //ARRAYS

        //1. Declaração de Array
        string[] fruits = { "Maça", "banana", "Caju", "manga"};

        //2. Acessar valores
            Console.WriteLine(fruits[0]);
            Console.WriteLine(separator);
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine(separator);


        //3. Constagem de indices
            Console.WriteLine("Quantidade de indices: " + fruits.Length);
            // A propriedade Length serve para te dizer o tamanho total de um array, ou seja, quantos elementos existem dentro da caixa
            Console.WriteLine(separator);
        
        //4. Alterar valor do array
            Console.WriteLine("Valor antes da alteração: " + fruits[1]);
            fruits[1] = "abacaxi";
            Console.WriteLine("Valor depois da alteração: " + fruits[1]);
            Console.WriteLine(separator);

        //5. Declaração Sem inicializar

        int[] numbers = new int[3];

        Console.WriteLine("Teste de Arrays, introduzindo valores\n");
        Console.WriteLine("Digite o valor do primeiro vetor: ");
        numbers[0] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo vetor: ");
        numbers[1] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor do terceiro vetor: ");
        numbers[2] = Convert.ToInt32(Console.ReadLine());

        foreach (int number in numbers)
        {
            Console.WriteLine("vetores introduzidos: " + number);
        }

        }
    }
}