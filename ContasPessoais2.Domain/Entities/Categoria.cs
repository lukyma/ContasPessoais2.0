using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Categoria
    {
        public Categoria()
        {
            Lancamentos = new HashSet<Lancamento>();
            SubCategorias = new HashSet<Categoria>();
        }
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public int? CategoriaPaiId { get; set; }
        public int? PessoaId { get; set; }
        public string SiglaOperacaoCategoria { get; set; }
        public virtual Categoria CategoriaPai { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Categoria> SubCategorias { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        public string DescricaoOperacao
        {
            get
            {
                switch (SiglaOperacaoCategoria)
                {
                    case "D":
                        return "Despesa";
                    case "R":
                        return "Receita";
                    case "I":
                        return "Investimento";
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
