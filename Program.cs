using System.Reflection.Metadata;
using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Software", 100.00M,dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

//System.Console.WriteLine(serializado);






















// int numero = 10;
// bool ehPar = false;

// //If ternario
// ehPar = numero % 2 == 0;

// System.Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

// Pessoa p1 = new Pessoa("Douglas", "Nunes");

// (string nome, string sobrenome) = p1;



// (int, string, string) tupla = (1, "Douglas", "Nunes");


// System.Console.WriteLine(tupla.Item1);



// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     foreach (string linhas in linhasArquivo)
//     {
//         System.Console.WriteLine(linhas);
//     }
// }
// else
// {
//     System.Console.WriteLine("Não foi possivel ler o arquivo");
// }















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

