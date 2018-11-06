using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContasPessoais2.Domain.Entities;
using FluentValidation.Validators;

namespace ContasPessoais2.Domain.Entities.Validator.PessoaValidator
{
    public class PessoaAddValidator : AbstractValidator<Pessoa>
    {
        public PessoaAddValidator()
        {
            this.RuleFor(o => o.Nome).NotEmpty().NotNull();
        }
    }
}
