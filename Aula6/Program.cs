using System;
namespace Aula6
{
    public class Program
    {
         public static void Main(string[] args)
        {
                // Operadores de atribuição

                //Inicializar variavel
            int x = 10;
            Console.WriteLine("Valor de X: "+ x);

                //operador de atribuiçaõ Simples
            x = 20;
            Console.WriteLine("\nAtribuiçãp simples (=)");
            Console.WriteLine("Valor de X: " + x);

                //Atribuiçao composta(imcrementado) (++)
                 x++; // Isso equivale a X = X + 1
            Console.WriteLine("\nAtribuição Composta de incremento (++)");
            Console.WriteLine("\nNovo valor de X: " + x);

                //Atribuiçao composta(+=)
                 x += 10; //Isso equivale x = x - 10
            Console.WriteLine("\nAtribuição Composta de incremento (+=)");
            Console.WriteLine("\nNovo valor de X: " + x);

                //Atribuiçao composta(-=)
                 x -= 10; //Isso equivale x = x + 10
            Console.WriteLine("\nAtribuição Composta de incremento (-=)");
            Console.WriteLine("\nNovo valor de X: " + x);            

                //Atribuiçao composta(*=)
                 x *= 10; //Isso equivale x = x * 10
            Console.WriteLine("\nAtribuição Composta de incremento (*=)");
            Console.WriteLine("\nNovo valor de X: " + x); 

                //Atribuiçao composta(/=)
                 x /= 10; //Isso equivale x = x / 10
            Console.WriteLine("\nAtribuição Composta de incremento (/=)");
            Console.WriteLine("\nNovo valor de X: " + x);                    

        }
    }
}