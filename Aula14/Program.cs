using System;
namespace Aula14
{
    public class Program
    {
         public static void Main(string[] args)
        {
            /*foreach* = funciona em lista, strings, numeros e vc quer que ele faça alguma coisa ali*/

            List<int> numberList = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            foreach(int number in numberList)
            {
                //FAÇA LOGO

                Console.WriteLine(number);
            }

            
        }
    }
}