using System;
namespace Aula1
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //**Variaveis**//
            //o que são variaveis?
            // Principais tipos de variáveis em C#

            //    int (Números inteiros): Guarda números sem vírgula, positivos ou negativos.

            //      Exemplo: int idade = 25;

            //    double / decimal (Números com vírgula): Guarda valores decimais.

            //    Exemplo: double preco = 19.90;

            //    string (Texto): Guarda uma sequência de caracteres (sempre entre aspas duplas).

            //    Exemplo: string nome = "Gustavo";

            //    bool (Booleano): Guarda apenas dois valores possíveis: verdadeiro (true) ou falso (false).

            //    Exemplo: bool estaLogado = true;


            string Myname = "Gustavo";
            int number = 21;
            double altura = 1.60;
            char endereço = 'a';

           Console.WriteLine("Me chamo:" + Myname);
           Console.WriteLine("Minha idade:" + number);
           Console.WriteLine("Minha altura:" + altura);
           Console.WriteLine("endereço:" + endereço);
        }
    }
}