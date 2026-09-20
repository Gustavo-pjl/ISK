using System;
using System.IO;
using System.Collections.Generic; // Biblioteca necessária para utilizar List<T>

namespace Aula18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // LISTA DE COMPRAS
            // 1. Estrutura de Caminhos e Ficheiros
            string Path = @"C:\Users\Gustavo\Documents\ISK\Aula18\"; // O '@' ignora os caracteres de escape nas barras '\'
            string FileName = "Lista de compras.txt"; // Nome do ficheiro físico com a extensão de texto
            string FilePath = Path + FileName; // Concatenação do caminho completo do ficheiro

            List<string> ShoppingList = new List<string>();
            /* 'new List<string>()' aloca um espaço limpo na memória RAM.
               A lista começa vazia e vai guardar apenas dados do tipo texto. */

            // Lógica de leitura inicial (Carregar dados existentes)
            if (File.Exists(FilePath)) // Verifica no disco rígido se o ficheiro existe antes de tentar ler
            {   
                ShoppingList.AddRange(File.ReadAllLines(FilePath));
                /* File.ReadAllLines(FilePath): Abre o ficheiro, lê cada linha e devolve um Array de strings.
                   ShoppingList.AddRange(...): Pega nesse Array inteiro e carrega todos os elementos para a lista na RAM. */
            }

            // Loop principal que mantém a aplicação a correr
            while (true) // Ciclo infinito. O menu só fecha quando o programa encontrar o comando 'return'
            {
                Console.WriteLine("\n==============Lista de compras==============");
                Console.WriteLine("1: Adicionar item");
                Console.WriteLine("2: Remover item");
                Console.WriteLine("3: Exibir Lista");
                Console.WriteLine("4: Sair");
                Console.WriteLine("Escolha um numero para continuar:");

                string ChoiceUser = Console.ReadLine(); // Captura a opção digitada pelo utilizador

                // Avalia a opção escolhida pelo utilizador
                switch (ChoiceUser)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do produto que deseja adicionar:");
                        string itemInsert = Console.ReadLine(); // Captura o nome do produto

                        if (!string.IsNullOrEmpty(itemInsert)) 
                        // IsNullOrEmpty verifica se está vazio ou nulo. O '!' inverte a lógica: "Se NÃO for vazio"
                        // Pois eu não vou inserir um vazio e se o vazio é vdd, inverto com ! e faço cair no else
                        {
                            ShoppingList.Add(itemInsert); // Adiciona o produto ao final da lista na memória RAM
                            Console.WriteLine($"Item '{itemInsert}' adicionado com sucesso!");                  
                        }
                        else
                        {
                            Console.WriteLine("O item é vazio"); // Proteção contra entradas em branco
                        }
                        break; // Sai do switch e regressa ao início do ciclo 'while'

                    case "2":
                        Console.WriteLine("Digite o nome do produto que deseja remover:");
                        string itemToremove = Console.ReadLine(); // Captura o item a eliminar

                        if (ShoppingList.Remove(itemToremove))
                        /* 'Remove()' procura o item na lista:
                           - Se encontrar: Remove o item e devolve 'true' (executa o 'if').
                           - Se NÃO encontrar: Devolve 'false' (executa o 'else'). */
                        {
                            Console.WriteLine($"Item '{itemToremove}' removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Item não encontrado");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Itens da sua lista:");

                        // A sua ideia da validação (checar se está vazio)
                        if (ShoppingList.Count == 0) 
                        {
                            Console.WriteLine("Sua lista está vazia");
                        }
                        else // Se for MENTIRA que está vazia (ou seja, tem itens), faz o foreach
                        {
                            int contador = 1; // Criamos um contador manual começando em 1

                            // Lê-se: "Para cada 'item' dentro da 'ShoppingList'..."
                            foreach (string item in ShoppingList)
                            {
                                Console.WriteLine($"{contador}. {item}");
                                contador++; // Aumenta 1 no contador para o próximo item
                            }
                        }
                        break;

                    case "4":
                        // Escreve todos os itens da ShoppingList no ficheiro físico. Se o ficheiro não existir, cria-o automaticamente!
                        File.WriteAllLines(FilePath, ShoppingList);
                        Console.WriteLine("Lista salva com sucesso!");
                        return; // Encerra a execução do método Main e mata o ciclo 'while(true)'

                    default:
                        // Executado caso o utilizador digite algo fora de "1", "2", "3" ou "4"
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}