// See https://aka.ms/new-console-template for more information
using C_DIO_Propriedades_Métodos_e_Contrutores.Models;


Console.WriteLine("Hello, World!");
Pessoa pessoa = new Pessoa("Ariel", "Brandon");

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Mathias";
pessoa1.Sobrenome = "Flores";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa);
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.ListarAlunos();





// pessoa.Idade = 24;
// //Podemos tambem criar propriedades do tipo Somente Leitura, Sem poder fazer alterações pelo Set.
// //pessoa.NomeCompleto = "Teste";
// pessoa.Apresentar();

