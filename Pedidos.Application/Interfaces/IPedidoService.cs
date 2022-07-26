using Pedidos.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IPedidoService
    {
        public List<PedidoDTO> List();

        public PedidoDTO GetPedido(int PedidoId);

        public int UpdatePedido(PedidoDTO pedidoDTO);
        public int CreatePedido(PedidoDTO pedidoDTO);
    }
}
