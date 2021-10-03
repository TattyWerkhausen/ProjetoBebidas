using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.ViewModels.Pedidos
{
    public class PedidoVM
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public List<PedidoBebidaVM> PedidosBebidasVM { get; set; }

    }
}
