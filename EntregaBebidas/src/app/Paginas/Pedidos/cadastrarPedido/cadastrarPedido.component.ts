import { ISubFormCliente } from './../../../Models/Pedidos/subformularios';
import { BebidaService } from './../../../Services/bebida.service';
import { BebidaModelExibicao } from './../../../Models/Bebidas/bebidaModelExibição';
import { PedidoModel } from './../../../Models/Pedidos/pedidoModel';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ClienteModelExibicao } from 'src/app/Models/Clientes/clienteModelExibicao';
import { ClienteService } from 'src/app/Services/cliente.service';
import { ISubformularioPedidoBebida } from 'src/app/Models/Pedidos/subformularios';

@Component({
  selector: 'app-cadastrarPedido',
  templateUrl: './cadastrarPedido.component.html',
  styleUrls: ['./cadastrarPedido.component.css']
})
export class CadastrarPedidoComponent implements OnInit {
  pedidos: PedidoModel[] = [];
  formulario: FormGroup;
  idAtualSubformulario = 0;
  subformulariosPedidoBebida: ISubformularioPedidoBebida[] = [];
  subFormCliente: ISubFormCliente[] = [];
  bebidas: BebidaModelExibicao[] = [];
  clientes: ClienteModelExibicao[] = [];


  constructor(private formBuilder: FormBuilder, rotaAtiva: ActivatedRoute, private bebidaService: BebidaService
    , private clienteService: ClienteService) {
    this.formulario = formBuilder.group({
      id: formBuilder.control(''),
      //  idCliente: formBuilder.control(rotaAtiva.snapshot.params.clienteId),
      dadosCliente: formBuilder.control([], [Validators.required], rotaAtiva.snapshot.params.clienteId),
      pedidosBebidas: formBuilder.control([], [Validators.required])
    });
    bebidaService.exibirTodasBebidas().subscribe(bebidasConsultadas => this.bebidas = bebidasConsultadas);
    clienteService.exibirTodos().subscribe(clienteConsulta => this.clientes = clienteConsulta);
  }

  ngOnInit() {
  }
  cadastrarPedido(): void {
  }

  addSubformulario(): void {
    let subformulario = {
      id: this.idAtualSubformulario,
      form: this.formBuilder.group({
        id: this.formBuilder.control(''),
        idBebida: this.formBuilder.control('', [Validators.required]),
        idPedido: this.formBuilder.control('')
      })
    };
    // valueChanges é chamado cada vez o valor do formulario mudar
    subformulario.form.valueChanges.subscribe(valorFormulario => {
      this.obterValorDeTodosSubfrmularios();
    });
    this.subformulariosPedidoBebida.push(subformulario);
    this.idAtualSubformulario++;
  }
  obterValorDeTodosSubfrmularios(): void {
    let pedidosBebidas: any[] = [];

    this.subformulariosPedidoBebida.forEach(subformulario => {
      pedidosBebidas.push(subformulario.form.value)
    });

    this.formulario.controls.pedidosBebidas.setValue(pedidosBebidas);
    console.log(this.formulario.value);

  }
  addSubFormCliente(): void {
    let subFormsCliente = {
      formCliente: this.formBuilder.group({
        id: this.formBuilder.control(''),
        nome: this.formBuilder.control(''),
        rua: this.formBuilder.control(''),
        bairro: this.formBuilder.control(''),
      })
    };
    subFormsCliente.formCliente.valueChanges.subscribe(valorForm => {
      this.obterValorTodosFormCliente();
    });
    this.subFormCliente.push(subFormsCliente);
  }
  obterValorTodosFormCliente(): void {
    let clientess: any[] = [];

    this.subFormCliente.forEach(subFormsCliente => {
      clientess.push(subFormsCliente.formCliente.value);
    });
    this.formulario.controls.clientess.setValue(clientess);
  }
}


