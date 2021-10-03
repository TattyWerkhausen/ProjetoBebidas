using AutoMapper;
using EntregaBebida.Api.ViewModels.Bebida;
using EntregaBebida.Domain.Model.Bebidas;
using EntregaBebida.Repository.Bebidas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class BebidaController : Controller
    {
        private readonly BebidaRepository _bebidaRepository;
        private readonly IMapper _autoMapper;
        public BebidaController(BebidaRepository bebidaRepository, IMapper autoMapper)
        {
            _bebidaRepository = bebidaRepository;
            _autoMapper = autoMapper;
        }
        [HttpPost("cadastrarBebida")]
        public async Task<IActionResult> RegistrarBebidaAsync([FromBody] BebidaVM bebidaVm)
        {
            bebidaVm.Id = Guid.NewGuid();
            var bebida = _autoMapper.Map<Bebida>(bebidaVm);
            await _bebidaRepository.RegistrarBebidaAsync(bebida);
            return Ok();

        }
        [HttpGet("buscarPorId/{id}")]
        public async Task<IActionResult> BuscarBebidaPorIdAsync(Guid id)
        {
            var bebidaId = await _bebidaRepository.BuscarBebidasPorIdAsync(id);
            var bebidaVm = _autoMapper.Map<Bebida>(bebidaId);
            return Ok(bebidaVm);

        }
        [HttpGet("exibirTodas")]
        public async Task<IActionResult> BuscarTodasBebidasAsync()
        {
            var bebidas = await _bebidaRepository.BuscarTodasBebidasAsync();
            var bebidaModel = _autoMapper.Map<List<BebidaVM>>(bebidas);

            return Ok(bebidaModel);
        }
    }
}
