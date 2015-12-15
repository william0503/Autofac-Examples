using AutofacTest.Entidades;

namespace AutofacTest
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var sistema = new Sistema();
            System.Console.WriteLine(sistema.DigaOlaPara(new Pessoa {Nome = "William", Sobrenome = "Rocha"}));
            System.Console.ReadKey();
        }
    }
}
