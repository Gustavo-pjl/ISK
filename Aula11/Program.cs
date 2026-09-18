using System;
namespace Aula11
{
    public class Program
    {
         public static void Main(string[] args)
        {
                //ESTRUTURA DE REPETIÇÃO = WHILE

        //        int i = 0; //contador

        //    while (i <= 5) //vai ser o criterio
        //    {
        //        Console.WriteLine("Loop infinito");
         //       i++; //vai repetir a condição até o criterio ser atingido

        // =========================================================================
        // CONCEITO: OPERADOR DE INCREMENTO (++) E DECREMENTO (--)
        // =========================================================================
        //
        // 1. O QUE FAZ:
        //    - i++ : Adiciona +1 ao valor atual da variável (i = i + 1).
        //    - i-- : Subtrai -1 do valor atual da variável (i = i - 1).
        //
        // 2. ONDE É MAIS USADO:
        //    - Em laços de repetição (for, while) para contar passagens/repetições.
        //    - Como um contador simples dentro do código.
        // =========================================================================
        //    }

        double budget = 100;
            while (budget > 0)
            {
                 Console.WriteLine(budget);//realiza alguma operação
                   budget--; //vai repetir a condição até o criterio ser atingido
            }

                Console.WriteLine("Saldo insuficente");


        }
    }
}