using Autofac;
using AutofacTest.Entidades;
using AutofacTest.Entidades.Interfaces;

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
            //Usando PropertiesAutowired
            //builder.RegisterType<Funcionario>().As<IFuncionario>().PropertiesAutowired().InstancePerDependency();
            //builder.RegisterType<Pessoa>().As<IPessoa>().InstancePerDependency();

            //Usando lambda
            builder.Register(x => new Funcionario { Pessoa = x.Resolve<IPessoa>() }).As<IFuncionario>().InstancePerDependency();
            builder.RegisterType<Pessoa>().As<IPessoa>().AsSelf().InstancePerDependency();
            
            _container = builder.Build();
        }

        public string DigaOlaPara(string nome, string sobrenome)
        {
            var funcionario = _container.Resolve<IFuncionario>();
            funcionario.NomearPessoa(nome,sobrenome);
            return "Ol� para " + funcionario.ObterNomeCompletoFuncionario();
        }
    }
}