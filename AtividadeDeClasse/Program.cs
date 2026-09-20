using System;
using System.IO;
using System.Collections.Generic;

namespace AtividadeDeClasse
{
    public class Program
    {
         public static void Main(string[] args)
        {
            // 1. A LISTA FICA DE FORA DO LOOP PARA NÃO SOFRER AMNÉSIA
            List<Forma_di_bolo> formaListas = new List<Forma_di_bolo>();
            
            bool varContinue = true;
            string Separador = "\n---------------------------------\n";

            while(varContinue)
            {
                
                Console.WriteLine("Maquina de criação de bolo");
                Console.WriteLine(Separador);
                Console.WriteLine("MENU");
                Console.WriteLine("ESCOLHA UMA DAS OPÇÕES");
                Console.WriteLine("CRIAR BOLO: 1 ");
                Console.WriteLine("VER BOLOS CRIADOS: 2 ");
                string opção = Console.ReadLine();

                // 2. APLICAMOS AS CONDIÇÕES DO MENU (IF / ELSE)
                if (opção == "1")
                {
                    var BoloNovo = new Forma_di_bolo(); 

                    Console.WriteLine("Informe os dados para criar seu bolo");
                    Console.WriteLine(Separador);

                    Console.WriteLine("Informe o SKU do seu Bolo");
                    BoloNovo.Sku = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o Nome do seu Bolo");
                    BoloNovo.Name = Console.ReadLine();

                    Console.WriteLine("Informe o descrição do seu Bolo");
                    BoloNovo.Descrição = Console.ReadLine();

                    Console.WriteLine("Informe o valor do seu Bolo");
                    BoloNovo.Valor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nosso bolo possui 5 ingredientes, informe eles");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Digite o ingrediente '{i + 1}':");
                        BoloNovo.Ingredientes[i] = Console.ReadLine();
                    }

                    // Guarda o bolo na lista
                    formaListas.Add(BoloNovo);
                    Console.WriteLine("\nBolo criado e guardado com sucesso!");
                }
                else if (opção == "2")
                {
                    Console.WriteLine(Separador);
                    Console.WriteLine("LISTA DE BOLOS CRIADOS:");
                    
                    // 3. USAMOS A VARIÁVEL 'formado' PARA IMPRIMIR OS DADOS
                    foreach(Forma_di_bolo formado in formaListas)
                    {
                        Console.WriteLine("\nDetalhes do bolo:");
                        Console.WriteLine("Sku do bolo: " + formado.Sku);
                        Console.WriteLine("Nome do bolo: " + formado.Name);
                        Console.WriteLine("Descrição do bolo: " + formado.Descrição);
                        Console.WriteLine("Valor do bolo: " + formado.Valor);
                        
                        Console.WriteLine("Ingredientes:");
                        foreach(string ingrediente in formado.Ingredientes)
                        {
                            Console.WriteLine("-- " + ingrediente);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                Console.WriteLine("\nDeseja realizar outra operação (s/n)?");
                string resposta = Console.ReadLine();

                if (resposta != "s")
                {
                    varContinue = false;
                    Console.WriteLine("\nObrigado por usar a máquina de bolos!");    
                }
            }
        }
    }
}