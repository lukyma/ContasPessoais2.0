using ContasPessoais2.Data.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(string connectionStringName)
            : base(connectionStringName)
        {
        }
        public BaseDbContext()
            : base()
        {
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
