import { CadastrarPedidoBebidaComponent } from './Paginas/Pedidos/PedidosBebida/cadastrarPedidoBebida/cadastrarPedidoBebida.component';
import { ExibirTodosClientesComponent } from './Paginas/Cliente/exibirTodosClientes/exibirTodosClientes.component';
import { ExibirTodasBebidasComponent } from './Paginas/Bebidas/exibirTodasBebidas/exibirTodasBebidas.component';
import { CadastroBebidaComponent } from './Paginas/Bebidas/cadastro-bebida/cadastro-bebida.component';
import { LayoutComponent } from './Paginas/layout/layout.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarClienteComponent } from './Paginas/Cliente/CadastrarCliente/CadastrarCliente.component';
import { CadastrarPedidoComponent } from './Paginas/Pedidos/cadastrarPedido/cadastrarPedido.component';
import { PedidoBebidaExibirTodosComponent } from './Paginas/Pedidos/PedidosBebida/pedidoBebidaExibirTodos/pedidoBebidaExibirTodos.component';

const routes: Routes = [
  { path: '', redirectTo: 'layout', pathMatch: 'full' },
  { path: 'layout', component: LayoutComponent },
  { path: 'cadastrarCliente', component: CadastrarClienteComponent },
  { path: 'cadastrarPedido', component: CadastrarPedidoComponent },
  { path: 'cadastrarBebida', component: CadastroBebidaComponent },
  { path: 'exibirTodasBebidas', component: ExibirTodasBebidasComponent },
  { path: 'exibirTodosClientes', component: ExibirTodosClientesComponent },
  { path: 'cadastrarPedidoBebida/:clienteId', component: CadastrarPedidoBebidaComponent },
  { path: 'exibirTodosPedidosBebidas', component: PedidoBebidaExibirTodosComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
