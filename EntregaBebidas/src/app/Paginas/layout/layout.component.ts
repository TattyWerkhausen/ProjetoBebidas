import { BebidaService } from './../../Services/bebida.service';
import { ClienteModel } from '../../Models/Clientes/Cliente';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ClienteService } from 'src/app/Services/cliente.service';
import { BebidaModel } from 'src/app/Models/Bebidas/bebidaModel';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {
  clientes: ClienteModel[] = [];
  bebidas: BebidaModel[] = [];
  formGroup: FormGroup;

  constructor(private formBuilder: FormBuilder, private clienteService: ClienteService
    , private bebidaService: BebidaService) {
    this.formGroup = formBuilder.group({
      nome: formBuilder.control('')
    });
  }

  ngOnInit() {
  }
  buscarPorNome(): void {
    const clienteNome = this.formGroup.controls.nome.value;
    this.clienteService.buscarPorNome(clienteNome).subscribe((nomeResultado) => {
      this.clientes = nomeResultado
    });
  }
  seEncontrouCliente(): boolean {
    if (this.clientes.length > 0) return true;
    return false;
  }
  exibirTodasBebidas(): void {
    this.bebidaService.exibirTodasBebidas().subscribe(todasBebidas => { this.bebidas = todasBebidas });
  }
}
