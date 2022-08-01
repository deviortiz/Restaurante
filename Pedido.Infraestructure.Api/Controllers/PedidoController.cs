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
        public Task<PedidoDTO> GetPedido(Guid pedidoId)
        {
            PedidoService service = CreateService();
            PedidoDTO pedidoDTO = service.GetPedido(pedidoId);
            return Task.FromResult(pedidoDTO);
        }

        [HttpPost("Actualizar")]
        public Task<Guid> UpdatePedido([FromBody] PedidoDTO pedido) {
            PedidoService service = CreateService();
            Guid pedidoId = service.UpdatePedido(pedido);

            return Task.FromResult(pedidoId);
        }

        [HttpPost("Crear")]
        public Task<Guid> CreatePedido([FromBody] PedidoDTO pedido)
        {
            PedidoService service = CreateService();
            service.CreatePedido(pedido);
            return Task.FromResult(pedido.PedidoId);
        }
    }
}
