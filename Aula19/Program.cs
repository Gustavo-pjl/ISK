using System;
using System.IO;
using System.Collections.Generic; // Biblioteca necessária para utilizar List<T>

namespace Aula19
{
    public class Program
    {
        public static void Main(string[] args) //<------aplicação de console começa aqui
        {
            //Aula de orientação a objetos

            //ORGANIZAÇÃO
            string Separador = "\n---------------------------------\n";

            //A FORMA DE BOLO ----> CLASSE/MOLDE
            //A INSTANCIA É O BOLO DE MORANGO ----OBJETO REAL
            //NEW = É a ordem para fabricar o objeto e reservar espaço na memória RAM


            //1. Instancia de objeto da classe forma de bolo

            var Bolo_De_Morango = new Forma_do_bolo(); //sempre que formos criar uma instancia de uma classe, usamos o new

            //2. Setar as informações do bolo

            Bolo_De_Morango.Id = 472;
            Bolo_De_Morango.Name = "Bolo de morango";
            Bolo_De_Morango.Description = "Proibido para lactante";
            Bolo_De_Morango.Valor = 30;
            Bolo_De_Morango.Isfiiling = true;

            //instancia --> ligado o forno e pegamos a forma

            //3.Vamos printar na tela

            Console.WriteLine("Id do bolo: " + Bolo_De_Morango.Id);
            Console.WriteLine("Nome do bolo: " + Bolo_De_Morango.Name);
            Console.WriteLine("Descrição do bolo: " + Bolo_De_Morango.Description);
            Console.WriteLine("valor do bolo R$: " + Bolo_De_Morango.Valor);
            Console.WriteLine("Existe este bolo: " + Bolo_De_Morango.Isfiiling);

            //4. Instancia do bolo de chocolate

            Console.WriteLine(Separador);
            
            var Bolo_De_Chocolate = new Forma_do_bolo(); //sempre que formos criar uma instancia de uma classe, usamos o new

            //2. Setar as informações do bolo

            Bolo_De_Chocolate.Id = 472;
            Bolo_De_Chocolate.Name = "Bolo de Cholate";
            Bolo_De_Chocolate.Description = "Proibido para lactante";
            Bolo_De_Chocolate.Valor = 30;
            Bolo_De_Chocolate.Isfiiling = true;

            //instancia --> ligado o forno e pegamos a forma

            //3.Vamos printar na tela

            Console.WriteLine("Id do bolo: " + Bolo_De_Chocolate.Id);
            Console.WriteLine("Nome do bolo: " + Bolo_De_Chocolate.Name);
            Console.WriteLine("Descrição do bolo: " + Bolo_De_Chocolate.Description);
            Console.WriteLine("valor do bolo R$: " + Bolo_De_Chocolate.Valor);
            Console.WriteLine("Existe este bolo: " + Bolo_De_Chocolate.Isfiiling);
            
            Console.WriteLine(Separador);

            //5.Lista de bolo

            List<Forma_do_bolo> formasList = new List<Forma_do_bolo>();

            formasList.Add(Bolo_De_Morango);
            formasList.Add(Bolo_De_Chocolate);

            Console.WriteLine(Separador);

            //6. Vizualizar

            foreach(Forma_do_bolo forma in formasList)
            {
            Console.WriteLine("Id do bolo: " + forma.Id);
            Console.WriteLine("Nome do bolo: " + forma.Name);
            Console.WriteLine("Descrição do bolo: " + forma.Description);
            Console.WriteLine("valor do bolo R$: " + forma.Valor);
            Console.WriteLine("Existe este bolo: " + forma.Isfiiling);
            }



        }
    }
}