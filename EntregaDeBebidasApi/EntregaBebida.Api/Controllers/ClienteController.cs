using AutoMapper;
using EntregaBebida.Api.ViewModels.Cliente;
using EntregaBebida.Domain.Model.Clientes;
using EntregaBebida.Repository.Clientes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly IMapper _autoMapper;

        public ClienteController(ClienteRepository clienteRepository, IMapper autoMapper)
        {
            _clienteRepository = clienteRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> RegistrarClienteAsync([FromBody] ClienteVM clienteViewModel)
        {
            clienteViewModel.Id = Guid.NewGuid();
            var cliente = _autoMapper.Map<Cliente>(clienteViewModel);
            await _clienteRepository.RegistrarClienteAsync(cliente);
            return Ok();
        }

        [HttpGet("buscarPorNome")]
        public async Task<IActionResult> BuscarTodosAsync(string nome)
        {
            if (nome == null) nome = "";
            var clientes = await _clienteRepository.BuscarPorNomeAsync(nome);

            var exibirTodosModel = _autoMapper.Map<List<ClienteVM>>(clientes);
            return Ok(exibirTodosModel);
        }
        [HttpGet("exibirTodos")]
        public async Task<IActionResult> ExibirTodosClientesAsync()
        {
            var clientes = await _clienteRepository.BuscarTodosAsync();
            var exibirTodosModel = _autoMapper.Map<List<ClienteVM>>(clientes);
            return Ok(exibirTodosModel);
        }
    }


}
