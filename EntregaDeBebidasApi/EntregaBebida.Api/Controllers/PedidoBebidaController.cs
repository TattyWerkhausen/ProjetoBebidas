using AutoMapper;
using EntregaBebida.Api.ViewModels.Pedidos;
using EntregaBebida.Domain.Model.Pedidos;
using EntregaBebida.Repository.Contexts;
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
    public class PedidoBebidaController : Controller
    {
        private readonly PedidoBebidaRepository _pedidoBebidaRepository;
        private readonly IMapper _iMapper;
        public PedidoBebidaController(PedidoBebidaRepository pedidoBebidaRepository, IMapper autoMapper)
        {
            _pedidoBebidaRepository = pedidoBebidaRepository;
            _iMapper = autoMapper;
        }
        [HttpPost("cadastrar")]
        public async Task<IActionResult> RegistrarPBAsync([FromBody] PedidoBebidaVM pedidoBebidaVM)
        {
            pedidoBebidaVM.Id = Guid.NewGuid();
            var pedidoB = _iMapper.Map<PedidoBebida>(pedidoBebidaVM);
            await _pedidoBebidaRepository.RegistrarPedidoBebidaAsync(pedidoB);
            return Ok();
        }
        [HttpGet("buscarTodos")]
        public async Task<IActionResult> BuscarTodosPBAsync()
        {
            var pedidosB = await _pedidoBebidaRepository.BuscarTodosPBAsync();
            var buscarTodosVM = _iMapper.Map<List<PedidoBebidaVM>>(pedidosB);

            return Ok(buscarTodosVM);
        }
        [HttpGet("buscarPBPorId/{id}")]
        public async Task<IActionResult> BuscarPBPorIdAsync(Guid id)
        {
            var pedidosBId = await _pedidoBebidaRepository.BuscarPBIdAsync(id);
            var pedidoBVM = _iMapper.Map<PedidoBebidaVM>(pedidosBId);

            return Ok(pedidoBVM);
        }
    }
}
