
namespace Pedidos.Domain.Models
{
    public class MenuDia
    {
        public Guid MenuDiaId { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadInicial { get; set; }
        public int CantidadDisponible { get; set; }
        public string Comentarios { get; set; }
        public List<Menu> Menus { get; set; }
    }
}