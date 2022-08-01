
namespace Pedidos.Domain.Models
{
    public class Menu
    {
        public Guid MenuId { get; set; }
        public string NombreMenu { get; set; }
        public int Costo { get; set; }
        public string TipoMenu { get; set; }
        public string Estado { get; set; }
        public DetallePedido DetallePedido { get; set; }
        public MenuDia MenuDia { get; set; }
    }
}
