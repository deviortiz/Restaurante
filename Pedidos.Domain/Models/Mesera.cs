using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Models
{
    public class Mesera
    {
        public Guid MeseraId { get; set; }
        public string NombreMesera { get; set; }
        public string Estado { get; set; }
        public string Telefono { get; set; }
        public string Comentarios { get; set; }

        public Pedido Pedido { get; set; }

    }
}
