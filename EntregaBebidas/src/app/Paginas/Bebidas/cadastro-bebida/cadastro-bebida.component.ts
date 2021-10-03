import { BebidaService } from './../../../Services/bebida.service';
import { BebidaModel } from './../../../Models/Bebidas/bebidaModel';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastro-bebida',
  templateUrl: './cadastro-bebida.component.html',
  styleUrls: ['./cadastro-bebida.component.css']
})
export class CadastroBebidaComponent implements OnInit {
  bebidas: BebidaModel[] = [];
  formulario: FormGroup;

  constructor(private fB: FormBuilder, private bebidaService: BebidaService, private rota: Router) {
    this.formulario = fB.group({
      nome: fB.control('', [Validators.required]),
      valorCusto: fB.control('', [Validators.required]),
      valorVenda: fB.control('', [Validators.required]),
    });
  }

  ngOnInit(): void {
  }
  cadastrarBebida(): void {
    const novaBebida = new BebidaModel(
      this.formulario.controls.nome.value,
      this.formulario.controls.valorCusto.value,
      this.formulario.controls.valorVenda.value
    );
    this.bebidaService.cadastrar(novaBebida).subscribe(() => {
      this.formulario.controls.nome.setValue('');
      this.formulario.controls.valorCusto.setValue('');
      this.formulario.controls.valorVenda.setValue('')
    })
    this.rota.navigateByUrl('/layout');
  }
}
