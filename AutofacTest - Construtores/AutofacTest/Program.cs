using Autofac;
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

    public class Sistema
    {
        private IContainer _container;

        public Sistema()
        {
            Start();
        }

        public void Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Pessoa>().As<IPessoa>().InstancePerDependency();
            builder.RegisterType<Funcionario>().As<IFuncionario>().InstancePerDependency();
            _container = builder.Build();
        }

        public string DigaOlaPara(string nome, string sobrenome)
        {
            var funcionario = _container.Resolve<IFuncionario>();
            funcionario.NomearPessoa(nome,sobrenome);
            return funcionario.ObterNomeCompletoFuncionario();
        }
    }


    public interface IPessoa
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
        string NomeCompleto();

    }
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        
        public string NomeCompleto()
        {
            return string.Format("{0} {1}", Nome, Sobrenome);
        }
    }

    public interface IFuncionario
    {
        string ObterNomeCompletoFuncionario();
        void NomearPessoa(string nome, string sobrenome);
    }

    public class Funcionario : IFuncionario
    {
        private IPessoa _pessoa;

        public Funcionario(IPessoa pessoa)
        {
            _pessoa = pessoa;
        }

        public string ObterNomeCompletoFuncionario()
        {
            return _pessoa.NomeCompleto();
        }

        public void NomearPessoa(string nome, string sobrenome)
        {
            _pessoa.Nome = nome;
            _pessoa.Sobrenome = sobrenome;
        }
    }
}
