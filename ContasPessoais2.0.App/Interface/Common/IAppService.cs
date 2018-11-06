using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.App.Interface.Common
{
    public interface IAppService<TEntity> where TEntity : class
    {
        ValidationResult Add(TEntity entity);
    }
}
