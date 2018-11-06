using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class CartaoCredito
    {
        public int CartaoCreditoId { get; set; }
        public int PessoaId { get; set; }
        public string Descricao { get; set; }
        public int BandeiraId { get; set; }
        public virtual Tipo Bandeira { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
