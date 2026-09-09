using System;
namespace Aula8
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //OPERADORES LOGÍCOS

        Console.WriteLine(" Operadores Lógicos");

        bool isLogged = true;
        bool hasAdminAcess = false;

         Console.WriteLine("\nInformação do Usuario");
         Console.WriteLine(" Usuario Logado: " + isLogged);
         Console.WriteLine(" Acesso ao Painel De Admin: " + hasAdminAcess);
          

            //OPERADOR (||) - OU    
        //    - Funciona como um "filtro flexível".
        //    - Retorna TRUE se PELO MENOS UMA das condições for verdadeira.
        //    - Só retorna FALSE se TODAS as condições forem falsas.
        //    - Tabela Verdade:
        //      true  || true  -> TRUE
        //      true  || false -> TRUE
        //      false || true  -> TRUE
        //      false || false -> FALSE (Apenas este NÃO entra no if)
        //
        // 3. CURTO-CIRCUITO (Short-Circuit):
        //    - No (&&): Se a primeira parte for FALSE, o C# nem checa o resto.
        //    - No (||): Se a primeira parte for TRUE, o C# nem checa o resto.
        // =========================================================================


         Console.WriteLine("\nPermissões");  

            if (isLogged  || hasAdminAcess)
            {
              Console.WriteLine("Acesso ao Sistema Concedido");
            }
            else
            {
                Console.WriteLine("Acesso ao Sistema Negado");
            }                 

            //Operador (&&) - E
        //    - Funciona como um "filtro rigoroso".
        //    - Retorna TRUE apenas se TODAS as condições forem verdadeiras.
        //    - Se QUALQUER uma for falsa, o resultado final será FALSE.
        //    - Tabela Verdade:
        //      true  && true  -> TRUE  (Apenas este entra no if)
        //      true  && false -> FALSE
        //      false && true  -> FALSE
        //      false && false -> FALSE    

            if (isLogged  && hasAdminAcess)
            {
              Console.WriteLine("Acesso ao Painel de Administrador Concedido");
            }
            else
            {
                Console.WriteLine("Acesso ao Painel de Administrador Negado");
            }


            //OPERADOR DE NEGAÇÃO (!) - "NÃO . . . "

            if (isLogged)
            {
              Console.WriteLine("Usuario não logado");
            }
            else
            {
                Console.WriteLine("Usuario logaado");
            }

        }
    }
}