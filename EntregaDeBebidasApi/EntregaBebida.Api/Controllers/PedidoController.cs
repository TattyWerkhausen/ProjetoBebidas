using AutoMapper;
using EntregaBebida.Api.ViewModels.Pedidos;
using EntregaBebida.Domain.Model.Pedidos;
using EntregaBebida.Repository.Pedidos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class PedidoController : Controller
    {
        private readonly PedidoRepository _pedidoRepository;
        private readonly IMapper _autoMapper;
        public PedidoController(PedidoRepository pedidoRepository, IMapper autoMapper)
        {
            _pedidoRepository = pedidoRepository;
            _autoMapper = autoMapper;
        }
        [HttpPost("cadastrar")]
        public async Task<IActionResult> RegistrarPedidoAsync([FromBody] PedidoVM pedidoVm)
        {
            pedidoVm.Id = Guid.NewGuid();
            var novoPedido = _autoMapper.Map<Pedido>(pedidoVm);
            await _pedidoRepository.RegistrarPedidoAsyn(novoPedido);
            return Ok();
        }
        [HttpGet("buscarTodos")]
        public async Task<IActionResult> BuscarTodosPedidosAsync()
        {
            var pedidos = await _pedidoRepository.BuscarTodosPedidosAsync();
            var pedidosVm = _autoMapper.Map<List<PedidoBebidaVM>>(pedidos);
            return Ok(pedidosVm);
        }
        [HttpGet("buscarPedidoPorId/{id}")]
        public async Task<IActionResult> BuscarPedidoPorIdAsync(Guid id)
        {
            var pedidoId = await _pedidoRepository.BuscarPedidoIdAsync(id);
            var pedidoViewModel = _autoMapper.Map<PedidoBebidaVM>(pedidoId);
            return Ok(pedidoViewModel);
        }
    }
}
