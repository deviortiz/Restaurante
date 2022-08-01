
namespace Pedidos.Domain.Models
{
    public class Pedido
    {
        public Guid PedidoId { get; set; }
        public string DescripcionPedido { get; set; }
        public DateTime FechaHora { get; set; } 
        public int Cantidad { get; set; }
        public string Llevar { get; set; }
        public string Comentarios { get; set; }
        public string Estado { get; set; }

        public List<Mesa> Mesas { get; set; }
        public List<Mesera> Meseras { get; set; }

    }

}
