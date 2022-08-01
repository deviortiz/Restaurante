using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Infraestructure.Data.Configs
{
    class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(c => c.PedidoId);

            builder
            .HasMany(Pedido => Pedido.Mesas)
            .WithOne(Mesa => Mesa.Pedido);

            builder
            .HasMany(Pedido => Pedido.Meseras)
            .WithOne(Mesera => Mesera.Pedido);
        }
    }
}
