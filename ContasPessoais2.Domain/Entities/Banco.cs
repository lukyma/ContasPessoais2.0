using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Banco
    {
        public Banco()
        {
            Contas = new HashSet<Conta>();
        }

        public int BancoId { get; set; }
        public string NumeroBanco { get; set; }
        public string NomeBanco { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }

    }
}
