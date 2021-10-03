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
    public class PedidoBebidaFA : IEntityTypeConfiguration<PedidoBebida>
    {
        public void Configure(EntityTypeBuilder<PedidoBebida> builder)
        {
            builder.HasKey(pB => pB.Id);
            builder.HasOne(pB => pB.Pedido).WithMany(p => p.PedidosBebidas).HasForeignKey(pB => pB.IdPedido);
            builder.HasOne(pB => pB.Bebida).WithMany(b => b.PedidosBebidas).HasForeignKey(pB => pB.IdBebida);
        }
    }
}
