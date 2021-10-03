using EntregaBebida.Domain.Model.Bebidas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Domain.Model.Pedidos
{
    public class PedidoBebida
    {
        public Guid Id { get; private set; }
        public Guid IdBebida { get; private set; }
        public Guid IdPedido { get; private set; }
        public Bebida Bebida { get; private set; }
        public Pedido Pedido { get; private set; }

        public PedidoBebida(Guid id, Guid idBebida, Guid idPedido)
        {
            Id = id;
            IdBebida = idBebida;
            IdPedido = idPedido;
        }
        public PedidoBebida()
        {
        }
    }
}
