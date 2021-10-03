using EntregaBebida.Domain.Model.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.ViewModels.Cliente
{
    public class ClienteVM
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
