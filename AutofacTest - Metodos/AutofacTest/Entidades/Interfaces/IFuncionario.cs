namespace AutofacTest.Entidades.Interfaces
{
    public interface IFuncionario
    {
        string ObterNomeCompletoFuncionario();
        void DefinirPessoa(IPessoa pessoa);
        void NomearPessoa(string nome, string sobrenome);
    }
}