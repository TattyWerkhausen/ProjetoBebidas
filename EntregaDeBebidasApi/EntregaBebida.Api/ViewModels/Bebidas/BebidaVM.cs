using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.ViewModels.Bebida
{
    public class BebidaVM
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double ValorCusto { get; set; }
        public double ValorVenda { get; set; }
    }
}
