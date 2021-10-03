import { ClienteModelExibicao } from './../../../Models/Clientes/clienteModelExibicao';
import { Component, OnInit } from '@angular/core';
import { ClienteService } from 'src/app/Services/cliente.service';

@Component({
  selector: 'app-exibirTodosClientes',
  templateUrl: './exibirTodosClientes.component.html',
  styleUrls: ['./exibirTodosClientes.component.css']
})
export class ExibirTodosClientesComponent implements OnInit {
  clientes: ClienteModelExibicao[] = [];

  constructor(private clienteService: ClienteService) { }

  ngOnInit() {
  }
  exibirTodosClientes(): void {
    this.clienteService.exibirTodos().subscribe(exibir => { this.clientes = exibir });
  }
}
