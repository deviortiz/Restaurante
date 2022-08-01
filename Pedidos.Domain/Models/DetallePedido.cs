
namespace Pedidos.Domain.Models
{
    public class DetallePedido
    {
        public Guid DetallePedidoId { get; set; }
        public int Cantidad { get; set; }
        public string Comentarios { get; set; }

        public List<Pedido> Pedidos { get; set; }
        public List<Menu> Menus { get; set; }
    }
}