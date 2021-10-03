import { BebidaModelExibicao } from './../../../Models/Bebidas/bebidaModelExibição';
import { BebidaService } from './../../../Services/bebida.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-exibirTodasBebidas',
  templateUrl: './exibirTodasBebidas.component.html',
  styleUrls: ['./exibirTodasBebidas.component.css']
})
export class ExibirTodasBebidasComponent implements OnInit {
  bebidas: BebidaModelExibicao[] = [];

  constructor(private bebidaService: BebidaService) { }

  ngOnInit() {
  }
  exibirTodasBebidas(): void {
    this.bebidaService.exibirTodasBebidas().subscribe(todasBebidas => { this.bebidas = todasBebidas });
  }
}
