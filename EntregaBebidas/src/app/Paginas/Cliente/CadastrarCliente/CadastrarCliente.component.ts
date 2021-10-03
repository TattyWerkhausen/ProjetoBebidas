import { ClienteService } from './../../../Services/cliente.service';
import { ClienteModel } from '../../../Models/Clientes/Cliente';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-CadastrarCliente',
  templateUrl: './CadastrarCliente.component.html',
  styleUrls: ['./CadastrarCliente.component.css']
})
export class CadastrarClienteComponent implements OnInit {
  clientes: ClienteModel[] = [];
  formGroup: FormGroup;

  constructor(private formBuilder: FormBuilder
    , private clienteService: ClienteService
    , private rota: Router) {
    this.formGroup = formBuilder.group({
      nome: formBuilder.control(''),
      rua: formBuilder.control(''),
      bairro: formBuilder.control('')
    });
  }

  ngOnInit() {
  }
  cadastrarCliente(): void {
    const novoCliente = new ClienteModel(
      this.formGroup.controls.nome.value,
      this.formGroup.controls.rua.value,
      this.formGroup.controls.bairro.value,
    );
    this.clienteService.cadastrar(novoCliente).subscribe(resultado => {
      this.formGroup.controls.nome.setValue('', [Validators.required, Validators.maxLength(20)]);
      this.formGroup.controls.rua.setValue('', [Validators.required]);
      this.formGroup.controls.bairro.setValue('', [Validators.required]);
    })
    this.rota.navigateByUrl('/cadastrarPedido');
  }
}
