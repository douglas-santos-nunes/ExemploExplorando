using ExemploExplorando.Models;

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção. {ex.Message}");
}








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

