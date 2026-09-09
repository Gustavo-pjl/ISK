using System;
namespace Aula2
{
    public class Program
    {
         public static void Main(string[] args)
        {
        //Constantes:
        // =========================================================================
        // ANOTAÇÕES: O QUE SÃO CONSTANTES?
        // =========================================================================
        // 1. Usa-se a palavra-chave 'const' antes do tipo de dado.
        // 2. O valor DEVE ser atribuído obrigatoriamente na declaração.
        // 3. O valor se torna IMUTÁVEL (não pode ser alterado depois).
        // 4. Boa prática: nomes de constantes usam PascalCase ou TUDO_MAIUSCULO.
        // =========================================================================
        var variavel = 500;
        Console.WriteLine("VARIAVEL:" + variavel);
        }
    }
}