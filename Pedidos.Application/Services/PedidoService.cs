using Pedidos.Application.Interfaces;
using Pedidos.Domain.DTOs;
using Pedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class PedidoService : IPedidoService 
    {
        private readonly IPedidoRepository repo;

        public PedidoService(IPedidoRepository _repo)
        {
            repo = _repo;
        }

        public Guid CreatePedido(PedidoDTO pedidoDTO)
        {
            return repo.CreatePedido(pedidoDTO);
        }

        public PedidoDTO GetPedido(Guid PedidoId)
        {
           return repo.GetPedido(PedidoId);
        }

        public List<PedidoDTO> List()
        {
            return repo.List();           
        }

        public Guid UpdatePedido(PedidoDTO pedidoDTO)
        {
            return repo.UpdatePedido(pedidoDTO);
        }
    }
}
