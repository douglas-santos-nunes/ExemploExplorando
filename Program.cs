using ExemploExplorando.Models;
// using System.Globalization;

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("RS", "Rio Grande do Sul");
// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"{item.Key}, {item.Value}");
// }





























// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// pilha.Pop();

// foreach (int item in pilha)
// {
//     System.Console.WriteLine(item);
// }




















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// fila.Dequeue();

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }







// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }








// Pessoa p = new Pessoa("Douglas","Nunes");

// //p.Nome="Douglas";
// //p.Sobrenome = "Nunes";

// Pessoa p2 = new Pessoa("Teste","Testenildo");

// //p2.Nome="Teste";
// //p2.Sobrenome = "Testenildo";

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Curso de Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

