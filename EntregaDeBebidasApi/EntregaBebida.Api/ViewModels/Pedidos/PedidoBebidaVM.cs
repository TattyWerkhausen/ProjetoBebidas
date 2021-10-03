using EntregaBebida.Domain.Model.Pedidos;
using EntregaBebida.Domain.Model.Bebidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntregaBebida.Api.ViewModels.Bebida;
using EntregaBebida.Api.ViewModels.Cliente;

namespace EntregaBebida.Api.ViewModels.Pedidos
{
    public class PedidoBebidaVM
    {
        public Guid Id { get; set; }
        public Guid IdBebida { get; set; }
        public Guid IdPedido { get; set; }
    }
}
