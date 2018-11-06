using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Conta
    {
        public Conta()
        {
            Lancamentos = new HashSet<Lancamento>();
        }
        public int ContaId { get; set; }
        public int PessoaId { get; set; }
        public int BancoId { get; set; }
        public int NumeroConta { get; set; }
        public int DigitoConta { get; set; }
        public int NumAgencia { get; set; }
        public string NomeAgencia { get; set; }

        public virtual Banco Banco { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
