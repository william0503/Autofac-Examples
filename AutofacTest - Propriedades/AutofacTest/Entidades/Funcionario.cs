using AutofacTest.Entidades.Interfaces;

namespace AutofacTest.Entidades
{
    public class Funcionario : IFuncionario
    {
        public IPessoa Pessoa { get; set; }

        public Funcionario()
        {
        }

        public string ObterNomeCompletoFuncionario()
        {
            return Pessoa.NomeCompleto();
        }

        public void NomearPessoa(string nome, string sobrenome)
        {
            Pessoa.Nome = nome;
            Pessoa.Sobrenome = sobrenome;
        }
    }
}