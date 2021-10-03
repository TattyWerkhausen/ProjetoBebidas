using EntregaBebida.Domain.Model.Clientes;
using EntregaBebida.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Repository.Clientes
{
    //Onde vou ter dentro de cada classe metodos de busca, edição, exclusão etc.
    // Estes metodos são responsaveis por enviar dados de quem os chamam para o banco de dados.

    public class ClienteRepository
    {
        //deve ser instanciado antes de ir para a injeção de dependencia
        private readonly EntregaBebidaDb _db;
        public ClienteRepository(EntregaBebidaDb db)
        {
            _db = db;
        }

        public EntregaBebidaDb DbContext { get; }

        public async Task RegistrarClienteAsync(Cliente cliente)
        {
            await _db.Clientes.AddAsync(cliente);
            await _db.SaveChangesAsync();
        }
        public async Task<Cliente> BuscarPorIdAsync(Guid id)
        {
            return await _db.Clientes.FirstOrDefaultAsync(clienteDb => clienteDb.Id == id);
        }
        public async Task<List<Cliente>> BuscarTodosAsync()
        {
            return await _db.Clientes.ToListAsync();
        }
        public async Task<List<Cliente>> BuscarPorNomeAsync(string nome)
        {
            return await _db.Clientes.Where(cliente => cliente.Nome == nome).ToListAsync();
        }
        public async Task EditarClienteAsync(Cliente cliente)
        {
            _db.Clientes.Update(cliente);
            await _db.SaveChangesAsync();
        }
        public async Task ExcluirClienteAsync(Guid id)
        {
            var clienteExcluir = await BuscarPorIdAsync(id);
            _db.Clientes.Remove(clienteExcluir);
            await _db.SaveChangesAsync();
        }
    }
}
