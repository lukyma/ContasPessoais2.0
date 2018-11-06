using ContasPessoais2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Data.Context.Mapping
{
    public class CartaoCreditoMapping : EntityTypeConfiguration<CartaoCredito>
    {
        public CartaoCreditoMapping()
        {
            HasKey(o => o.CartaoCreditoId);

            Property(o => o.Descricao).IsRequired().HasMaxLength(100);

            HasRequired(o => o.Pessoa)
                .WithMany(o => o.CartoesCredito)
                .HasForeignKey(o => o.PessoaId);
        }
    }
}
