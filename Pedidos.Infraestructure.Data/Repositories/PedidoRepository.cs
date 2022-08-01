using Pedidos.Domain.DTOs;
using Pedidos.Domain.Interfaces;
using Pedidos.Domain.Models;
using Pedidos.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Infraestructure.Data.Repositories
{
    public class PedidoRepository:  IPedidoRepository
    {
        private readonly PedidoContext db;

        public PedidoRepository(PedidoContext Db) => db = Db;

        public Guid CreatePedido(PedidoDTO pedidoDTO)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.PedidoId = pedidoDTO.PedidoId;
                pedido.DescripcionPedido = pedidoDTO.DescripcionPedido;
                pedido.Cantidad = pedidoDTO.Cantidad;
                pedido.FechaHora = DateTime.Now;

                db.Pedidos.Add(pedido);
                db.SaveChanges();

                return pedido.PedidoId;
            }
            catch(Exception) {
                throw;
            }                      
        }

        public PedidoDTO GetPedido(Guid PedidoId)
        {
            try
            {
                Pedido pedido = db.Pedidos.FirstOrDefault(c => c.PedidoId.Equals(PedidoId));
                PedidoDTO pedidoDTO = new PedidoDTO()
                {
                    PedidoId = pedido.PedidoId,
                    DescripcionPedido = pedido.DescripcionPedido,
                    Cantidad = pedido.Cantidad,
                    CreatedDate = pedido.FechaHora
                };
                return pedidoDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }

        public List<PedidoDTO> List()
        {
            
              return (from d in db.Pedidos
                    select new PedidoDTO { PedidoId = d.PedidoId, DescripcionPedido = d.DescripcionPedido, CreatedDate = d.FechaHora, Cantidad= d.Cantidad }).ToList();
        }


        public Guid UpdatePedido(PedidoDTO pedidoDTO)
        {
            try
            {
                Pedido pedido = db.Pedidos.FirstOrDefault(c => c.PedidoId.Equals(pedidoDTO.PedidoId));
                pedido.DescripcionPedido = pedidoDTO.DescripcionPedido;
                pedido.Cantidad = pedidoDTO.Cantidad;
                pedido.FechaHora = DateTime.Now;

                db.Pedidos.Update(pedido);
                db.SaveChanges();

                return pedido.PedidoId;
            }
            catch (Exception)
            {
                throw;
            }            

        }
    }
}
