import { ClienteModelExibicao } from './../Models/Clientes/clienteModelExibicao';
import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ClienteModel } from '../Models/Clientes/Cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  private baseApi = "";

  constructor(private httpService: HttpClient) { }

  cadastrar(cadastroCliente: ClienteModel): Observable<any> {
    return this.httpService.post<any>('https://localhost:44352/api/Cliente/cadastrar', cadastroCliente);
  }
  exibirTodos(): Observable<ClienteModelExibicao[]> {
    return this.httpService.get<ClienteModelExibicao[]>('https://localhost:44352/api/Cliente/exibirTodos');
  }
  buscarPorNome(nome: string): Observable<ClienteModel[]> {
    const params = new HttpParams().set('nome', nome);
    return this.httpService.get<ClienteModel[]>('https://localhost:44352/api/Cliente/buscarPorNome', { params });
  }
}
