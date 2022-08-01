using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Models
{
    public class Mesa
    {
        public Guid MesaId { get; set; }
        public string NombreMesa { get; set; }
        public int NumeroMesa { get; set; }
        public string Estado { get; set; }
        public string Comentarios { get; set; }
        public Pedido Pedido { get; set; }
    }
}
