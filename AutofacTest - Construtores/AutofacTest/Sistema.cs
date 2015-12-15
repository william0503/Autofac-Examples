using Autofac;

namespace AutofacTest
{
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
}