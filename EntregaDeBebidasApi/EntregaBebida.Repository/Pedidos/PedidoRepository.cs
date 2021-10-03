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
    public class PedidoRepository
    {
        private readonly EntregaBebidaDb _db;
        public PedidoRepository(EntregaBebidaDb db)
        {
            _db = db;
        }
        public EntregaBebidaDb DbContext { get; }
        public async Task RegistrarPedidoAsyn(Pedido pedido)
        {
            await _db.Pedidos.AddAsync(pedido);
            await _db.SaveChangesAsync();
        }
        public async Task<List<Pedido>> BuscarTodosPedidosAsync()
        {
            return await _db.Pedidos.ToListAsync();
        }
        public async Task<Pedido> BuscarPedidoIdAsync(Guid id)
        {
            return await _db.Pedidos.FirstOrDefaultAsync(ped => ped.Id == id);
        }
        public async Task EditarPedidoAsync(Pedido pedido)
        {
            _db.Pedidos.Update(pedido);
            await _db.SaveChangesAsync();
        }
        public async Task ExcluirPedidoAsync(Guid id)
        {
            var pedidoExcluir = await BuscarPedidoIdAsync(id);
            _db.Pedidos.Remove(pedidoExcluir);
            await _db.SaveChangesAsync();
        }
    }
}
