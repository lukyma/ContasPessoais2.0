using ContasPessoais2.Domain.Entities;
using ContasPessoais2.Domain.Entities.Validator;
using ContasPessoais2.Domain.Entities.Validator.PessoaValidator;
using FluentValidation;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.IoC.Modules
{
    public class ValidatorModule
    {
        public static void Register(Container container)
        {
            //var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            container.Register<IValidator<Pessoa>, PessoaAddValidator>(Lifestyle.Scoped);
        }
    }
}
