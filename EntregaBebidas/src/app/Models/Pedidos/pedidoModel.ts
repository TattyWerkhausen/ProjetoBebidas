
import { ClienteModel } from '../Clientes/Cliente';
import { pedidosBebidasModel } from './../PedidosBebidas/pedidosBebidasModel';
export class PedidoModel {
  constructor(
    public dadosCliente: ClienteModel[],
    public pedidoBebida: pedidosBebidasModel[],
  ) { }
}
