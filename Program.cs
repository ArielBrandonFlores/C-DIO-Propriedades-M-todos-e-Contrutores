using C_DIO_Propriedades_Métodos_e_Contrutores.Models;
Console.WriteLine("--------------------Tratamento de Exceções do tipo Throw------------------------------");

new ExemploExcecao().Metodo1();

//Tratamento de Execoções
Console.WriteLine("-------------------------Tratamento de Exceções do tipo Try Catch------------------");
try
{
    String[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
//Excessoes Especificas
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretorio não encontrado: {ex.Message}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
//Excessoes Genericas
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma Excessão generica: {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");

}























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

