using ContasPessoais2.Domain.Interfaces.Services;
using ContasPessoais2.Domain.Interfaces.Services.Common;
using ContasPessoais2.Domain.Services;
using ContasPessoais2.Domain.Services.Common;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.IoC.Modules
{
    public class ServiceModule
    {
        public static void Register(Container container)
        {
            container.Register(typeof(IService<>), typeof(Service<>), Lifestyle.Scoped);
            container.Register<IPessoaService, PessoaService>(Lifestyle.Scoped);
        }
    }
}
