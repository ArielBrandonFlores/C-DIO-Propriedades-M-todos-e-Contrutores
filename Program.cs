using C_DIO_Propriedades_Métodos_e_Contrutores.Models;
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o Elemento da Fila {fila.Dequeue()}");
foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------------------------");

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(14);
pilha.Push(11);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo elemtento do Topo da Pilha {pilha.Pop()}");
pilha.Push(16);
foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine("---------------------------------------------------------");



Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("PR", "Parana");
estados.Add("RS", "Rio Grande do Sul");

foreach (var item in estados)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------");
estados.Remove("PR");
estados["SP"] = "Valor Alterado";





foreach (var item in estados)
{
    Console.WriteLine(item);
}
















// Console.WriteLine("--------------------Tratamento de Exceções do tipo Throw------------------------------");

// new ExemploExcecao().Metodo1();

// //Tratamento de Execoções
// Console.WriteLine("-------------------------Tratamento de Exceções do tipo Try Catch------------------");
// try
// {
//     String[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// //Excessoes Especificas
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretorio não encontrado: {ex.Message}");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
// }
// //Excessoes Genericas
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma Excessão generica: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");

// }























// Console.WriteLine("Hello, World!");
// Pessoa pessoa = new Pessoa("Ariel", "Brandon");

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Mathias";
// pessoa1.Sobrenome = "Flores";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(pessoa);
// cursoDeIngles.AdicionarAluno(pessoa1);
// cursoDeIngles.ListarAlunos();





// pessoa.Idade = 24;
// //Podemos tambem criar propriedades do tipo Somente Leitura, Sem poder fazer alterações pelo Set.
// //pessoa.NomeCompleto = "Teste";
// pessoa.Apresentar();

