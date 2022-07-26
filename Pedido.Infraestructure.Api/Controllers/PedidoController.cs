using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Services;
using Pedidos.Domain.DTOs;
using Pedidos.Infraestructure.Data.Context;
using Pedidos.Infraestructure.Data.Repositories;

namespace Pedidos.Infraestructure.Api.Controllers
{
   // [EnableCors("MyPolicy")]
    [Route("api/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase 
    {
        static PedidoService CreateService()
        {
            PedidoContext db = new();
            PedidoRepository repo = new(db);
            PedidoService PedidoSearchService = new(repo);
            return PedidoSearchService;
        }

       // [EnableCors]
        [HttpGet]
        public Task<List<PedidoDTO>> List()
        {
           PedidoService service = CreateService();
            return Task.FromResult(service.List());
        }

        [HttpGet("{pedidoId:int}")]
        public Task<PedidoDTO> GetPedido(int pedidoId)
        {
            PedidoService service = CreateService();
            PedidoDTO pedidoDTO = service.GetPedido(pedidoId);
            return Task.FromResult(pedidoDTO);
        }

        [HttpPost("Actualizar")]
        public Task<int> UpdatePedido([FromBody] PedidoDTO pedido) {
            PedidoService service = CreateService();
            int pedidoId = service.UpdatePedido(pedido);

            return Task.FromResult(pedidoId);
        }

        [HttpPost("Crear")]
        public Task<int> CreatePedido([FromBody] PedidoDTO pedido)
        {
            PedidoService service = CreateService();
            service.CreatePedido(pedido);
            return Task.FromResult(pedido.Id);
        }
    }
}
