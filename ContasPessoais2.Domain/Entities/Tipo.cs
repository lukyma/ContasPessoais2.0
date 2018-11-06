using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Tipo
    {
        public Tipo()
        {
            SubTipos = new HashSet<Tipo>();
            CartoesCredito = new HashSet<CartaoCredito>();
        }
        public int TipoId { get; set; }
        public string Descricao { get; set; }
        public int? TipoPaiId { get; set; }
        public virtual Tipo TipoPai { get; set; }
        public virtual ICollection<Tipo> SubTipos { get; set; }
        public virtual ICollection<CartaoCredito> CartoesCredito { get; set; }
    }
}
