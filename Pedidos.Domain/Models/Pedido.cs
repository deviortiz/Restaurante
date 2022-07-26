using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string DescripcionPedido { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Cantidad { get; set; }
        public string valor { get; set; }
    }
}
