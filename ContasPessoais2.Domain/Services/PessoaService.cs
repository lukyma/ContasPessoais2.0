using ContasPessoais2.Domain.Entities;
using ContasPessoais2.Domain.Interfaces.Repository;
using ContasPessoais2.Domain.Interfaces.Services;
using ContasPessoais2.Domain.Services.Common;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Services
{
    public class PessoaService : Service<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _repository;
        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}
