using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_DIO_Propriedades_Métodos_e_Contrutores.Models
{
    public class Pessoa
    {
        //Implementando Construtures
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        //Validações com Get e Set
        private string _nome;
        private int _idade;

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public string Nome
        {
            // É um Body Expression, mais recomendado de utilizar em validações simples.
            // get =>_nome.ToUpper(); 
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade
        {
            //Exemplo de Body Expression
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade tem que ser maior que 0");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade {Idade}");
        }
    }
}