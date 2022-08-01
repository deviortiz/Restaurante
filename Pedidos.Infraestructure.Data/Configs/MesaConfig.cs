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
    public class MesaConfig : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("Mesa");
            builder.HasKey(c => c.MesaId);

            builder
             .HasOne(Mesa => Mesa.Pedido)
             .WithMany(Pedido => Pedido.Mesas);
        }
    }
}
