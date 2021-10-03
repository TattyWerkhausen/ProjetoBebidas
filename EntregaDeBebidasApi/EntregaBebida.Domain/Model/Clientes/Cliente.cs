using EntregaBebida.Domain.Model.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaBebida.Domain.Model.Clientes
{
    //Classe cliente obtem os dados necessarios, esta dentro da pasta model no meu dominio.
    //Representa como o cliente é dentro da aplicação
    //Depois iremos para nosso Repository que tera o Context, FA, os Repositorios e as migrations.
    //Depois Injetamos clienteRepository por dependencia na nossa Api, e configuramos na startup.
    //Depois vem a viewModel.
    //AutoMapper conversao dos dados do clienteviewmodel para cliente é feita através do automapper
    public class Cliente
    {
        //isto é para o entity framework, todo classe de dominio precisa ter construtor vazio
        protected Cliente()
        {

        }
        public Cliente(Guid id, string nome, string rua, string bairro, List<Pedido> pedidos)
        {
            Id = id;
            Nome = nome;
            Rua = rua;
            Bairro = bairro;
            Pedidos = pedidos;
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
