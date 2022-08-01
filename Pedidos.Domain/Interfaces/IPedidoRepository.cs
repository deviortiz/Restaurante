using Pedidos.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        public List<PedidoDTO> List();

        public PedidoDTO GetPedido(Guid PedidoId);
        public Guid UpdatePedido(PedidoDTO pedidoDTO);

        public Guid CreatePedido(PedidoDTO pedidoDTO);
    }
}
