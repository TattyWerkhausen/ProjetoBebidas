using EntregaBebida.Domain.Model.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Domain.Model.Bebidas
{
    public class Bebida
    {
        public Bebida()
        {
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public double ValorCusto { get; private set; }
        public double ValorVenda { get; private set; }
        public List<PedidoBebida> PedidosBebidas { get; set; }

        public Bebida(Guid id, string nome, double valorCusto, double valorVenda)
        {
            Id = id;
            Nome = nome;
            ValorCusto = valorCusto;
            ValorVenda = valorVenda;
        }
    }
}
