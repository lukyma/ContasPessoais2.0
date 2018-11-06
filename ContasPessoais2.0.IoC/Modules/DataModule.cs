using ContasPessoais2.Data;
using ContasPessoais2.Data.Context.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.IoC.Modules
{
    public class DataModule
    {
        public static void Register(Container container)
        {
            container.Register<IContasPessoaisContext, ContasPessoaisContext>(Lifestyle.Scoped);
        }
    }
}
