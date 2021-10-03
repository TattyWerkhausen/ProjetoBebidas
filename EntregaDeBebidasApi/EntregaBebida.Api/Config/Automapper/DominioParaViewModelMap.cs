using AutoMapper;
using EntregaBebida.Api.ViewModels.Bebida;
using EntregaBebida.Api.ViewModels.Cliente;
using EntregaBebida.Api.ViewModels.Pedidos;
using EntregaBebida.Domain.Model.Bebidas;
using EntregaBebida.Domain.Model.Clientes;
using EntregaBebida.Domain.Model.Pedidos;

namespace EntregaBebida.Api.Config.Automapper
{
    public class DominioParaViewModelMap : Profile
    {
        public DominioParaViewModelMap()
        {
            CreateMap<Cliente, ClienteVM>();
            CreateMap<Bebida, BebidaVM>();
            CreateMap<Pedido, PedidoVM>();
            CreateMap<PedidoBebida, PedidoBebidaVM>();
        }
    }
}
