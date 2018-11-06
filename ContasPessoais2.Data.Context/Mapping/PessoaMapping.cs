using ContasPessoais2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Data.Context.Mapping
{
    public class PessoaMapping : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMapping()
        {
            HasKey(o => o.PessoaId);
            Property(o => o.PessoaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.Email).IsRequired();
            Property(o => o.Nome).HasMaxLength(100);
            Property(o => o.Senha).HasMaxLength(40);
        }
    }
}
