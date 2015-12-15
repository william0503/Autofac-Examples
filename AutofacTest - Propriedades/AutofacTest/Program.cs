namespace AutofacTest
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var sistema = new Sistema();
            System.Console.WriteLine(sistema.DigaOlaPara("William", "Rocha"));
            System.Console.ReadKey();
        }
    }
}
