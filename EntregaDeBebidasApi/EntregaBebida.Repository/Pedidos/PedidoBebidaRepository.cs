using EntregaBebida.Domain.Model.Pedidos;
using EntregaBebida.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.Pedidos
{
    public class PedidoBebidaRepository
    {
        private readonly EntregaBebidaDb _db;
        public PedidoBebidaRepository(EntregaBebidaDb db)
        {
            _db = db;
        }
        public EntregaBebidaDb DbContext { get; }
        public async Task RegistrarPedidoBebidaAsync(PedidoBebida pedidoBebida)
        {
            await _db.PedidosBebidas.AddAsync(pedidoBebida);
            await _db.SaveChangesAsync();
        }
        public async Task<List<PedidoBebida>> BuscarTodosPBAsync()
        {
            return await _db.PedidosBebidas.ToListAsync();
        }
        public async Task<PedidoBebida> BuscarPBIdAsync(Guid id)
        {
            return await _db.PedidosBebidas.FirstOrDefaultAsync(pB => pB.Id == id);

        }
        public async Task EditarPBAsync(PedidoBebida pedidoBebida)
        {
            _db.PedidosBebidas.Update(pedidoBebida);
            await _db.SaveChangesAsync();
        }
        public async Task ExcluirPBAsync(Guid id)
        {
            var excluirPB = await BuscarPBIdAsync(id);
            _db.PedidosBebidas.Remove(excluirPB);
            await _db.SaveChangesAsync();
        }
    }
}