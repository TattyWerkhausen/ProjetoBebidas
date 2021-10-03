import { pedidosBebidasModel } from './../Models/PedidosBebidas/pedidosBebidasModel';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { pedidoBebidaModelExibicao } from '../Models/PedidosBebidas/pedidoBebidaModelExibicao';

@Injectable({
  providedIn: 'root'
})
export class PedidoBebidaService {
  private baseApi = "";

  constructor(private httpService: HttpClient) { }
  cadastrar(cadastrarPB: pedidosBebidasModel): Observable<any> {
    return this.httpService.post<any>('https://localhost:44352/api/PedidoBebida/cadastrar', cadastrarPB);
  }
  buscarTodos(): Observable<pedidoBebidaModelExibicao[]> {
    return this.httpService.get<pedidoBebidaModelExibicao[]>('https://localhost:44352/api/PedidoBebida/buscarTodos');
  }
}
