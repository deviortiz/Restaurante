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

        public int CreatePedido(PedidoDTO pedidoDTO)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.Id = pedidoDTO.Id;
                pedido.DescripcionPedido = pedidoDTO.DescripcionPedido;
                pedido.Cantidad = pedidoDTO.Cantidad;
                pedido.CreatedDate = DateTime.Now;

                db.Pedidos.Add(pedido);
                db.SaveChanges();

                return pedido.Id;
            }
            catch(Exception) {
                return 0;
            }                      
        }

        public PedidoDTO GetPedido(int PedidoId)
        {
            try
            {
                Pedido pedido = db.Pedidos.FirstOrDefault(c => c.Id.Equals(PedidoId));
                PedidoDTO pedidoDTO = new PedidoDTO()
                {
                    Id = pedido.Id,
                    DescripcionPedido = pedido.DescripcionPedido,
                    Cantidad = pedido.Cantidad,
                    CreatedDate = pedido.CreatedDate
                };
                return pedidoDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }

        public List<PedidoDTO> List()
        {
            
              return (from d in db.Pedidos
                    select new PedidoDTO { Id = d.Id, DescripcionPedido = d.DescripcionPedido, CreatedDate = d.CreatedDate, Cantidad= d.Cantidad }).ToList();
        }


        public int UpdatePedido(PedidoDTO pedidoDTO)
        {
            try
            {
                Pedido pedido = db.Pedidos.FirstOrDefault(c => c.Id.Equals(pedidoDTO.Id));
                pedido.DescripcionPedido = pedidoDTO.DescripcionPedido;
                pedido.Cantidad = pedidoDTO.Cantidad;
                pedido.CreatedDate = DateTime.Now;

                db.Pedidos.Update(pedido);
                db.SaveChanges();

                return pedido.Id;
            }
            catch (Exception)
            {
                return 0;
            }            

        }
    }
}
