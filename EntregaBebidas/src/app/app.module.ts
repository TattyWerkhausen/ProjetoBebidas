import { CadastrarPedidoBebidaComponent } from './Paginas/Pedidos/PedidosBebida/cadastrarPedidoBebida/cadastrarPedidoBebida.component';
import { ExibirTodosClientesComponent } from './Paginas/Cliente/exibirTodosClientes/exibirTodosClientes.component';
import { ExibirTodasBebidasComponent } from './Paginas/Bebidas/exibirTodasBebidas/exibirTodasBebidas.component';
import { ClienteService } from './Services/cliente.service';
import { NgModule } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastrarClienteComponent } from './Paginas//Cliente/CadastrarCliente/CadastrarCliente.component';
import { LayoutComponent } from './Paginas/layout/layout.component';
import { HttpClientModule } from '@angular/common/http';
import { CadastrarPedidoComponent } from './Paginas/Pedidos/cadastrarPedido/cadastrarPedido.component';
import { CadastroBebidaComponent } from './Paginas/Bebidas/cadastro-bebida/cadastro-bebida.component';
import { PedidoBebidaExibirTodosComponent } from './Paginas/Pedidos/PedidosBebida/pedidoBebidaExibirTodos/pedidoBebidaExibirTodos.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    CadastrarClienteComponent,
    CadastrarPedidoComponent,
    CadastroBebidaComponent,
    ExibirTodasBebidasComponent,
    ExibirTodosClientesComponent,
    CadastrarPedidoBebidaComponent,
    PedidoBebidaExibirTodosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [
    ClienteService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
