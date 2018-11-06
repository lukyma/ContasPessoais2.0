using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Lancamento
    {
        public int LancamentoId { get; set; }
        public int PessoaId { get; set; }
        public int CategoriaId { get; set; }
        public int? ContaBancariaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Resumo { get; set; }
        public decimal Valor { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Conta Conta { get; set; }
    }
}
