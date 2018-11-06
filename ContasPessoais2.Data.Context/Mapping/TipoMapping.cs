using ContasPessoais2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Data.Context.Mapping
{
    public class TipoMapping : EntityTypeConfiguration<Tipo>
    {
        public TipoMapping()
        {
            HasKey(o => o.TipoId);
            Property(o => o.TipoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasOptional(o => o.TipoPai)
                .WithMany(o => o.SubTipos)
                .HasForeignKey(o => o.TipoPaiId);
        }
    }
}
