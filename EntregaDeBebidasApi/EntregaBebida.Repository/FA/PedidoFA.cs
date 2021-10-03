using EntregaBebida.Domain.Model.Pedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.FA
{
    public class PedidoFA : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Cliente).WithMany(c => c.Pedidos).HasForeignKey(p => p.ClienteId);
        }
    }
}
