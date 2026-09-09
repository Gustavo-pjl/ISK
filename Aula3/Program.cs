using System;
namespace Aula3
{
    public class Program
    {
         public static void Main(string[] args)
        {


            //SISTEMA DE INSERÇÃO DE DADOS
            //IMPUT E OUTPOT
            Console.WriteLine("=====LOGIN=====");
            
            // solicitar nome
             Console.WriteLine("Digite Seu nome:");
             String Name = Console.ReadLine();

            // solicitar idade
             Console.WriteLine("Digite Sua Idade:");
             int idade = Convert.ToInt32(Console.ReadLine());


             Console.WriteLine("DADOS DO USUARIO" );
             Console.WriteLine("Nome do Usuario:" + Name);
             Console.WriteLine("idade do Usuario:" + idade);
        }
    }
}