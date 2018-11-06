using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {
            CartoesCredito = new HashSet<CartaoCredito>();
        }
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<CartaoCredito> CartoesCredito { get; set; }
    }
}
