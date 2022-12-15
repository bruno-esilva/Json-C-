//Faça um programa que leia itens de importação
//para isso você terá que criar um programa para ler arquivos json
//transformar estes arquivos em objetos
//armezenar os cliente na lista em memória
//mostrar o resultado na tela como um relatório


//terá uma pasta imports com os arquivos
//imports
//    cliente1.json
//    cliente2.json
//    cliente3.json
//    cliente4.json
//    cliente5.json   

//    Conteúdo do arquivo:
//        { "nome": "Danilo", "telefone": "123432123"}

using Aula.Models;
using System.Text.Json;
//using System.IO;

namespace exercicioAula;

class Program
{
    public const string file1 = (@"D:\Codigo-do-Futuro\dotnet\Aula12122022\Aula12122022\Imports\cliente1.json"); //Cria uma variável contendo o caminho do arquivo Json
    public const string file2 = (@"D:\Codigo-do-Futuro\dotnet\Aula12122022\Aula12122022\Imports\cliente2.json"); //Cria uma variável contendo o caminho do arquivo Json
    public const string file3 = (@"D:\Codigo-do-Futuro\dotnet\Aula12122022\Aula12122022\Imports\cliente3.json"); //Cria uma variável contendo o caminho do arquivo Json
    public const string file4 = (@"D:\Codigo-do-Futuro\dotnet\Aula12122022\Aula12122022\Imports\cliente4.json"); //Cria uma variável contendo o caminho do arquivo Json
    public const string file5 = (@"D:\Codigo-do-Futuro\dotnet\Aula12122022\Aula12122022\Imports\cliente5.json"); //Cria uma variável contendo o caminho do arquivo Json
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5 ; i++) //for para iterar os arquivos json com mesmo nome
        {
            using (var Reader = new StreamReader(@$"D:\Codigo-do-Futuro\dotnet\Aula12122022\Aula12122022\Imports\cliente{i}.json")) //Using para o StreamReader (Ler caracteres de um arquivo)
            {
                string json = Reader.ReadToEnd(); //Variável que indica que o Reader deve ler do início ao fim do texto capturado no arquivo
                var cliente = JsonSerializer.Deserialize<Cliente>(json, new JsonSerializerOptions //var cliente deserializa o conteúdo em um objeto do tipo Cliente
                {
                    PropertyNameCaseInsensitive = true //Ignorar maiúsculas e minúsculas
                });
                Console.WriteLine(cliente?.ToString()); //Imprime a variável cliente.
            }

        }
    }
}