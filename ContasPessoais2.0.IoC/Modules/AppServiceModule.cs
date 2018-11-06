using ContasPessoais2._0.App.App;
using ContasPessoais2._0.App.App.Common;
using ContasPessoais2._0.App.Interface;
using ContasPessoais2._0.App.Interface.Common;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.IoC.Modules
{
    public class AppServiceModule
    {
        public static void Register(Container container)
        {
            //container.Register(typeof(IAppService<>), typeof(AppService<>), Lifestyle.Scoped);
            container.Register<IPessoaAppService, PessoaAppService>(Lifestyle.Scoped);
        }
    }
}
