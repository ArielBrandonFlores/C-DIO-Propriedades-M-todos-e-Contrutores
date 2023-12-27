using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_DIO_Propriedades_Métodos_e_Contrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        //Métodos que não são void tem que ter o return por via de regra.
        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do Curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                //Concatenação
                //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                //Interpolação
                String texto = $"N° {count} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}