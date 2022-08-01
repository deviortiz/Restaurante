using Pedidos.Application.Interfaces;
using Pedidos.Domain.Interfaces;
using Pedidos.Domain.Models;
using System;

namespace Pedidos.Application.Services
{
    public class DetallePedidoService : IDetallePedidoService
    {
        private readonly IDetallePedidoRepository repo;

        public DetallePedidoService(IDetallePedidoRepository _repo)
        {
            repo = _repo;
        }
        public List<DetallePedido> List()
        {
            return repo.List();
        }
    }
}
