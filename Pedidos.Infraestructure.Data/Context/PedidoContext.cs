using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Infraestructure.Data.Configs;

namespace Pedidos.Infraestructure.Data.Context
{
    public class PedidoContext : DbContext
    {
        readonly string SERVERDB = "LAPTOP-SO3BL27O\\SQLEXPRESS";
        readonly string DBNAME = "Catalog";
        readonly string PORTDBSERVER = "1433";
        readonly string USERNAMEDB = "Cami";
        readonly string PASSWORDDB = "Camila2020.";

        public DbSet<Pedido> Pedidos { get; set; }


        public PedidoContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer($"Server={SERVERDB},{PORTDBSERVER};Initial Catalog={DBNAME};Persist Security Info=False;User ID={USERNAMEDB};Password={PASSWORDDB};MultipleActiveResultSets=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new PedidoConfig());
        }
        }
}
