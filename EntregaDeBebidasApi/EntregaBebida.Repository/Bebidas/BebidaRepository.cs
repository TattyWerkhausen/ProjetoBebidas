using EntregaBebida.Domain.Model.Bebidas;
using EntregaBebida.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.Bebidas
{
    public class BebidaRepository
    {
        private readonly EntregaBebidaDb _db;
        public BebidaRepository(EntregaBebidaDb db)
        {
            _db = db;
        }
        public EntregaBebidaDb DbContext { get; }
        public async Task RegistrarBebidaAsync(Bebida bebida)
        {
            await _db.Bebidas.AddAsync(bebida);
            await _db.SaveChangesAsync();
        }
        public async Task<Bebida> BuscarBebidasPorIdAsync(Guid id)
        {
            return await _db.Bebidas.FirstOrDefaultAsync(bebid => bebid.Id == id);
        }
        public async Task<List<Bebida>> BuscarTodasBebidasAsync()
        {
            return await _db.Bebidas.ToListAsync();
        }
        public async Task EditarBebidaAsync(Bebida bebida)
        {
            _db.Bebidas.Update(bebida);
            await _db.SaveChangesAsync();
        }
        public async Task ExcluirBebidaAsync(Guid id)
        {
            var bebidaExcluir = await BuscarBebidasPorIdAsync(id);
            _db.Bebidas.Remove(bebidaExcluir);
            await _db.SaveChangesAsync();
        }
    }
}
