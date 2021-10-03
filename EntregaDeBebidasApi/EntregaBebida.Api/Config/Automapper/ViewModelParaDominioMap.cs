using AutoMapper;
using EntregaBebida.Api.ViewModels.Bebida;
using EntregaBebida.Api.ViewModels.Cliente;
using EntregaBebida.Api.ViewModels.Pedidos;
using EntregaBebida.Domain.Model.Bebidas;
using EntregaBebida.Domain.Model.Clientes;
using EntregaBebida.Domain.Model.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.Config.Automapper
{
    public class ViewModelParaDominioMap : Profile
    {
        public ViewModelParaDominioMap()
        {
            CreateMap<ClienteVM, Cliente>().ConstructUsing(clienteVm => new Cliente(clienteVm.Id, clienteVm.Nome, clienteVm.Rua, clienteVm.Bairro, clienteVm.Pedidos));
            CreateMap<BebidaVM, Bebida>().ConstructUsing(bebidaVm => new Bebida(bebidaVm.Id, bebidaVm.Nome, bebidaVm.ValorCusto, bebidaVm.ValorVenda));
            CreateMap<PedidoBebidaVM, PedidoBebida>().ConstructUsing(pedidoBebidaVm => new PedidoBebida(pedidoBebidaVm.Id, pedidoBebidaVm.IdBebida, pedidoBebidaVm.IdPedido));
            CreateMap<PedidoVM, Pedido>().ConstructUsing((pedidoVm, context) => new Pedido(pedidoVm.Id, pedidoVm.IdCliente, context.Mapper.Map<List<PedidoBebida>>(pedidoVm.PedidosBebidasVM)));

        }
    }
}
