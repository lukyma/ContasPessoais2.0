using ContasPessoais2._0.App.Interface.Common;
using ContasPessoais2.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.App.Interface
{
    public interface IPessoaAppService : IAppService<Pessoa>
    {
        
    }
}
