namespace AutofacTest.Entidades.Interfaces
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
        string NomeCompleto();

    }
}