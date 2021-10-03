import { BebidaModelExibicao } from './../Models/Bebidas/bebidaModelExibição';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BebidaModel } from '../Models/Bebidas/bebidaModel';

@Injectable({
  providedIn: 'root'
})
export class BebidaService {

  private baseApi = '';
  constructor(private httpService: HttpClient) { }
  cadastrar(cadastrarBebida: BebidaModel): Observable<any> {
    return this.httpService.post<any>('https://localhost:44352/api/Bebida/cadastrar', cadastrarBebida);
  }
  exibirTodasBebidas(): Observable<BebidaModelExibicao[]> {
    return this.httpService.get<BebidaModelExibicao[]>('https://localhost:44352/api/Bebida/exibirTodas');
  }
}
