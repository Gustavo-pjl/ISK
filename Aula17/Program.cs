using System;
using System.IO;
namespace Aula17
{
    public class Program
    {
         public static void Main(string[] args)
        {
         /*Trabalhando com Arquivos files


         //1. Criar arquivo
        /string content = "hello word!";
        System.IO.File.WriteAllText("file1", content);

        Console.WriteLine("Arquivo criado com sucesso!");


        //2. Criar arquivpo em local especifico
        string path = @"C:\Users\Gustavo\Documents\ISK\Aula17\fileName.txt";
        string content = "Hello word";
        File.WriteAllText(path, content);
        Console.WriteLine("Arquivo criado com sucesso!");*/

        //3. Criar arquivo com outra extensão
        // string path = @"C:\Users\Gustavo\Documents\ISK\Aula17\";
        // string filename = "Test.doc";
        // string filePath = path + filename;
        // string content = "Hello word";
        
        // File.WriteAllText(filePath, content);
        // Console.WriteLine("Arquivo criado com sucesso!");

        //4. Inserir um paragrafo
        // string path = @"C:\Users\Gustavo\Documents\ISK\Aula17\";
        // string filename = "Test.doc";
        // string filePath = path + filename;

        // //conteudo
        // string additionalContent = "Curso de C# e Net";
        
        // File.AppendAllText(filePath, additionalContent);
        // Console.WriteLine("Arquivo criado com sucesso!");

        // //Lê o arquivo

        // string fileContent = File.ReadAllText(filePath);
        // Console.WriteLine("Conteudo do arquivo: " + fileContent);

        //5. Ler o arquivo
        string path = @"C:\Users\Gustavo\Documents\ISK\Aula17\";
        string filename = "Test.doc";
        string filePath = path + filename;

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Conteudo do arquivo: " + fileContent);
        }
    }
}