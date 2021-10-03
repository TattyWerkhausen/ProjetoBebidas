using EntregaBebida.Domain.Model.Bebidas;
using EntregaBebida.Domain.Model.Clientes;
using EntregaBebida.Domain.Model.Pedidos;
using EntregaBebida.Repository.FA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.Contexts
{
    public class EntregaBebidaDb : DbContext
    {
        //DbContextOptions para ser usado na service da startup.
        public EntregaBebidaDb(DbContextOptions<EntregaBebidaDb> options) : base(options) { }


        //DbSet: Sempre que uma classe que será representante de uma tabela,
        //no banco de dados deverá ter seu proprioDbSet antes mesmo de ter um repositorio.
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoBebida> PedidosBebidas { get; set; }

        //Você pode usar ModelBuilder para construir um modelo para um contexto substituindo OnModelCreating(ModelBuilder)
        //em seu contexto derivado. Como alternativa, você pode criar o modelo externamente e defini-lo em uma DbContextOptions
        //instância que é passada para o construtor de contexto.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteFA());
            modelBuilder.ApplyConfiguration(new BebidaFA());
            modelBuilder.ApplyConfiguration(new PedidoFA());
            modelBuilder.ApplyConfiguration(new PedidoBebidaFA());
            base.OnModelCreating(modelBuilder);
        }
    }
}
