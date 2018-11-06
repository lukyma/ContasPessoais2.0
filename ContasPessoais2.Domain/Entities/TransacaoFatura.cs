using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class TransacaoFatura
    {
        public int TransacaoFaturaId { get; set; }
        public int FaturaId { get; set; }
        public Fatura Fatura { get; set; }
    }
}
