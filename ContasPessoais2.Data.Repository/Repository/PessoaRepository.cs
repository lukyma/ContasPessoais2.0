
using ContasPessoais2.Data.Context.Interfaces;
using ContasPessoais2.Domain.Entities;
using ContasPessoais2.Domain.Interfaces;
using ContasPessoais2.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Data.Repository.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository  
    {
        public PessoaRepository(IContasPessoaisContext contasPessoaisContext): base(contasPessoaisContext)
        {
        }
    }

}
