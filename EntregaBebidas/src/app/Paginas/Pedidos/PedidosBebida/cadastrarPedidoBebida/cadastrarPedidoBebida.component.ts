import { PedidoBebidaService } from './../../../../Services/pedidoBebida.service';
import { FormGroup, FormBuilder } from '@angular/forms';
import { pedidosBebidasModel } from './../../../../Models/PedidosBebidas/pedidosBebidasModel';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cadastrarPedidoBebida',
  templateUrl: './cadastrarPedidoBebida.component.html',
  styleUrls: ['./cadastrarPedidoBebida.component.css']
})
export class CadastrarPedidoBebidaComponent implements OnInit {
  pedidosBebidas: pedidosBebidasModel[] = [];
  formulario: FormGroup;

  constructor(private fB: FormBuilder, private pBService: PedidoBebidaService) {
    this.formulario = fB.group({
      idBebida: fB.control('',),
      idPedido: fB.control(''),
    });
  }

  ngOnInit() {
  }
  cadastrarPedidoBebida(): void {
    const novoPB = new pedidosBebidasModel(
      this.formulario.controls.idBebida.value,
      this.formulario.controls.idPedido.value
    );
    this.pBService.cadastrar(novoPB).subscribe(resultado => {
      this.formulario.controls.idBebida.setValue(''),
        this.formulario.controls.idPedido.setValue('')
    });
  }
}
