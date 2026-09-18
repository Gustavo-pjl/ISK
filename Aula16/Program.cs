using System;
using System.Collections.Generic; // <--- OBRIGATÓRIO para usar Listas
namespace Aula16
{
    public class Program
    {
         public static void Main(string[] args)
        {
        
        String separator = "\n//////////////////////////////////////////////////////////\n";
        
        //1. Conceito de lista: Declaração de valores

        List<string> fruits = new List<string>()
        {
            "Manga", //indice 1
            "abacate", //indice 2
            "pera" //indice 3
        };


         Console.WriteLine("\nEssa é a lista de frutas");
         foreach (string fruit in fruits)
         {
          Console.WriteLine(fruit);  //Aqui ele vai imprimir a lista
         }
         /*separador*/ Console.WriteLine(separator);

        //2. Acessar valores: esse aqui ele so imprimi o valor/indice da lista

         Console.WriteLine("Imprimir valor predefinido: o escolhido foi o 2");
         Console.WriteLine("Fruta escolhida: " + fruits[2]);
         /*separador*/ Console.WriteLine(separator);



         Console.WriteLine("Aqui ele vai imprimir a lista toda com foreach");
         foreach (string fruit in fruits)
         {
          Console.WriteLine(fruit);  //Aqui ele vai imprimir a lista
         }
         /*separador*/ Console.WriteLine(separator);


         //3. Adicionar elementos
          Console.WriteLine("Nessa parte aqui, ele vai imprimir um indice predefino e perguntar outro para imprimir");
          Console.WriteLine("Escolha o nome de uma fruta: ");
          fruits.Add(Console.ReadLine());
          fruits.Add("Laranja");

          Console.WriteLine("Lista após a introdução");   
          foreach (string fruit in fruits)
         {
          Console.WriteLine(fruit);   
         }
         /*separador*/ Console.WriteLine(separator);


         //4. Remover Elementos

        Console.WriteLine("Escolha um elemento que deseja remover da lista");
        Console.WriteLine("Escreva exatamente o que deseja excluir: ");
         fruits.Remove(Console.ReadLine());
            foreach (string fruit in fruits)
         {
          Console.WriteLine(fruit);   
         }
         /*separador*/ Console.WriteLine(separator);

         //5. Contagem de elementos
          Console.WriteLine("Essa árte aqui conta os elementos");
          Console.WriteLine("Quantidade de elementos:  " + fruits.Count);
          /*separador*/ Console.WriteLine(separator);


        //6. Modificar um elemento
        Console.WriteLine("Essa parte modifica alguém da lista");
        Console.WriteLine("Escreva pelo o que quer substiruir a Manga");
        fruits[0] = Console.ReadLine();
            foreach (string fruit in fruits)
         {
          Console.WriteLine(fruit);   
         }
         /*separador*/ Console.WriteLine(separator);

        //7. Limpar lista
        Console.WriteLine("Essa parte vai limpar a lista");
         fruits.Clear();
         foreach (string fruit in fruits)
         {
          Console.WriteLine(fruit);   
         }
         /*separador*/ Console.WriteLine(separator);

        //8. Declarar sem inicializar
        List<int> numbers = new List<int>();

         foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        
        }
    }
}