using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.DTOs
{
    public class PedidoDTO
    {
        public Guid PedidoId { get; set; } 
        public string DescripcionPedido { get; set;}
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Cantidad { get; set; }
    }
}
