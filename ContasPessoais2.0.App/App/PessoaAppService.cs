using ContasPessoais2._0.App.App.Common;
using ContasPessoais2._0.App.Interface;
using ContasPessoais2.Domain.Entities;
using ContasPessoais2.Domain.Entities.Validator.PessoaValidator;
using ContasPessoais2.Domain.Interfaces.Services;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2._0.App.App
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;
        private readonly IValidator<Pessoa> _pessoaAddValidator;
        public PessoaAppService(IPessoaService pessoaService, IValidator<Pessoa> pessoaAddValidator)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
            _pessoaAddValidator = pessoaAddValidator;
        }

        public override ValidationResult Add(Pessoa entity)
        {
            return _pessoaService.Add(entity, _pessoaAddValidator);
        }
    }
}
