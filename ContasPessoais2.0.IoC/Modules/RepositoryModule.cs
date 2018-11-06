using ContasPessoais2.Data.Repository.Repository;
using ContasPessoais2.Domain.Interfaces;
using ContasPessoais2.Domain.Interfaces.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.IoC.Modules
{
    public class RepositoryModule
    {
        public static void Register(Container container)
        {
            container.Register(typeof(IRepository<>), typeof(Repository<>));
            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);
        }
    }
}
