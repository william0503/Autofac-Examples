using AutofacTest.Entidades.Interfaces;

namespace AutofacTest.Entidades
{
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        
        public string NomeCompleto()
        {
            return string.Format("{0} {1}", Nome, Sobrenome);
        }
    }
}