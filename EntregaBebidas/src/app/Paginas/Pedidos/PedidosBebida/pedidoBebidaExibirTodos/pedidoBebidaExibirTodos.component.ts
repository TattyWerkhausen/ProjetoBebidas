import { PedidoBebidaService } from './../../../../Services/pedidoBebida.service';
import { Component, OnInit } from '@angular/core';
import { pedidoBebidaModelExibicao } from 'src/app/Models/PedidosBebidas/pedidoBebidaModelExibicao';

@Component({
  selector: 'app-pedidoBebidaExibirTodos',
  templateUrl: './pedidoBebidaExibirTodos.component.html',
  styleUrls: ['./pedidoBebidaExibirTodos.component.css']
})
export class PedidoBebidaExibirTodosComponent implements OnInit {
  pedidoBebidaTodos: pedidoBebidaModelExibicao[] = [];

  constructor(private pbService: PedidoBebidaService) { }

  ngOnInit() {
  }
  exibirTodosPedidosBebidas(): void {
    this.pbService.buscarTodos().subscribe(pedidoB => { this.pedidoBebidaTodos = pedidoB });
  }
}
