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
    public class MeseraConfig : IEntityTypeConfiguration<Mesera>
    {
        public void Configure(EntityTypeBuilder<Mesera> builder)
        {
            builder.ToTable("Mesera");
            builder.HasKey(c => c.MeseraId);

            builder
            .HasOne(Mesera => Mesera.Pedido)
            .WithMany(Pedido => Pedido.Meseras);
        }
    }
}
