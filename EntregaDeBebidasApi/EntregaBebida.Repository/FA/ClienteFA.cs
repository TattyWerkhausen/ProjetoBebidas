using EntregaBebida.Domain.Model.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.FA
{
    //FA é quem irá dizer para o banco de dados como ele configurar a classe lá.
    //Exemplo: o tamanho de uma coluna, o nome da table, qual é sua chave primeiria, qual será seuas chaves estrangeiras.

    //Apartir deste momento deve ser dado o migration e então esta livre para criar o repository

    public class ClienteFA : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(20);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Rua).IsRequired();
            builder.Property(c => c.Bairro).IsRequired();

        }
    }
}
