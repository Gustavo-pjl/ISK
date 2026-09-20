using System;
using Aula20;
namespace Aula2
{
    public class Program
    {
         public static void Main(string[] args)
        {
        //1. Criar a instancia Banco

        var Banco_BB = new Banco();

        //2.Chamando o Métodos de instancia da Classe Banco

        Banco_BB.RequisiçãoDeCartao();

        }
    }
}