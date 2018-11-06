using ContasPessoais2._0.App.Interface.Common;
using ContasPessoais2.Domain.Interfaces.Services.Common;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.App.App.Common
{
    public abstract class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {
        private readonly IService<TEntity> _service;
        public AppService(IService<TEntity> service)
        {
            _service = service;
        }

        public abstract ValidationResult Add(TEntity entity);
    }
}
