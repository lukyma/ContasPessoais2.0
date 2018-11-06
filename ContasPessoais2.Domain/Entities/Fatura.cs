using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Fatura
    {
        public Fatura()
        {
            Transacoes = new HashSet<TransacaoFatura>();
        }
        public int FaturaId { get; set; }
        public int CartaoCreditoId { get; set; }
        public DateTime Data { get; set; }
        public virtual CartaoCredito CartaoCredito { get; set; }
        public virtual ICollection<TransacaoFatura> Transacoes { get; set; }
    }
}
