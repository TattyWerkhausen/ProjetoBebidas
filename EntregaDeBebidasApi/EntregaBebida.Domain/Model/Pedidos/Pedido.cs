using EntregaBebida.Domain.Model.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Domain.Model.Pedidos
{
    public class Pedido
    {
        public Pedido()
        {
        }
        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<PedidoBebida> PedidosBebidas { get; private set; }
        public Pedido(Guid id, Guid clienteId, List<PedidoBebida> pedidosBebidas)
        {
            Id = id;
            ClienteId = clienteId;
            PedidosBebidas = pedidosBebidas;
        }
    }
}
