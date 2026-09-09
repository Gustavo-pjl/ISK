using System;
namespace Aula5
{
    public class Program
    {
         public static void Main(string[] args)
        {
                  //OPERADORES RELACIONAIS
            Console.WriteLine("Digite o primeiro numero"); 
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            bool Condition = x == y;
            string resultado;
        
            //operador de igualdade (==) - verifica se os valores sao iguais

            if (x == y)
            {
                resultado = "X é igual a Y";
            }
            else
            {
                resultado = "X não é igual a Y";
            }
            Console.WriteLine("\nIgualdade (==): " + resultado);

            //operador de diferença (!=) - verifica se os valores sao diferentes
            if (x != y)
            {
                resultado = "X é diferente de Y";
            }
            else
            {
                resultado = "X não é diferente de Y";   
            }
            Console.WriteLine("\nDiferença (!=): " + resultado);

            //operador de maior que (>) - verifica se o valor da esquerda é maior que o da direita
            if (x > y)
            {
                resultado = "X é maior que Y";
            }
            else
            {
                resultado = "X não é maior que Y";   
            }
            Console.WriteLine("\nMaior que (>): " + resultado);

            //operador de menor que (<) - verifica se o valor da esquerda é menor que o da direita
            if (x < y)      
            {
                resultado = "X é menor que Y";
            }
            else
            {
                resultado = "X não é menor que Y";   
            }
            Console.WriteLine("\nMenor que (<): " + resultado);

            //operador de maior ou igual que (>=) - verifica se o valor da esquerda é maior ou igual que o da direita
            if (x >= y)     
            {
                resultado = "X é maior ou igual a Y";
            }
            else
            {
                resultado = "X não é maior ou igual a Y";   
            }                   

            //operador de menor ou igual que (<=) - verifica se o valor da esquerda é menor ou igual que o da direita
            if (x <= y)    
            {
                resultado = "X é menor ou igual a Y";
            }
            else
            {
                resultado = "X não é menor ou igual a Y";   
            }
            Console.WriteLine("\nMenor ou igual a (<=): " + resultado);
        }
    }
}