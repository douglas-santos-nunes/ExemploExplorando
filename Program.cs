using ExemploExplorando.Models;

Pessoa p = new Pessoa("Douglas","Nunes");

//p.Nome="Douglas";
//p.Sobrenome = "Nunes";

Pessoa p2 = new Pessoa("Teste","Testenildo");

//p2.Nome="Teste";
//p2.Sobrenome = "Testenildo";

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

