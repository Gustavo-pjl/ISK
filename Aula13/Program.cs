using System;
namespace Aula13
{
    public class Program
    {
         public static void Main(string[] args)
        {



            ///for / loop
        /*
            for (condicao 1; condicao 2; condicao 3)
            {
            // Code que será executado
            }

        CONDIÇÃO 1 é executada (uma unica vez) antes da execução do bloco de código.

        CONDIÇÃO 2 define a condição para executar o bloco de código.

        CONDIÇÃO 3 é executado (todas as vezes) após o bloco de código ter sido executado.
*/

 //EX1:

             
             Console.WriteLine("==========TABELA DE MULTIPLICAÇÃO==========");

              for(int i = 1; i <=10; i++)
              {
                for(int j = 1; j <=10; j++)
                {
                    //Console.WriteLine($"{i * j}" ); ;
                Console.Write($"{i * j,-5}"); ;
                }
                Console.WriteLine();
              }

        }
    }
}