import { Cliente } from './Cliente'
import { Empleado } from './Empleado'
import { Producto } from './Producto'

export class Venta {
  VentaId: number
  Fecha: Date
  Cliente: Cliente
  ClienteId: number
  Empleado: Empleado
  EmpleadoId: number
  Total: number
  Productos: Array<Producto>
}
