using EntregaBebida.Api.Config.Automapper;
using EntregaBebida.Repository.Bebidas;
using EntregaBebida.Repository.Clientes;
using EntregaBebida.Repository.Contexts;
using EntregaBebida.Repository.Pedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntregaBebida.Api.Config
{
    // InjeçaoDependencia crio meus services adicionando meus Repositorys
    // (é uma extensão da startup, por isso muitas vezes é referenciada pela startup).
    // lembrando de deixar a classe da injeção de dependencia publica e static.

    public static class InjecaoDependencia
    {
        public static IServiceCollection AddInjecaoDependencia(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof(DominioParaViewModelMap), typeof(ViewModelParaDominioMap));
            services.AddScoped<ClienteRepository>();
            services.AddScoped<BebidaRepository>();
            services.AddScoped<PedidoRepository>();
            services.AddScoped<PedidoBebidaRepository>();

            return services;
        }
    }
}
