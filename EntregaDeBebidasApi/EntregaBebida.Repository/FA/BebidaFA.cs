using EntregaBebida.Domain.Model.Bebidas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.FA
{
    public class BebidaFA : IEntityTypeConfiguration<Bebida>
    {
        public void Configure(EntityTypeBuilder<Bebida> builder)
        {

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Nome).HasMaxLength(20);
            builder.Property(b => b.Nome).IsRequired();
            builder.Property(b => b.ValorCusto).IsRequired();
            builder.Property(b => b.ValorVenda).IsRequired();
        }
    }
}
