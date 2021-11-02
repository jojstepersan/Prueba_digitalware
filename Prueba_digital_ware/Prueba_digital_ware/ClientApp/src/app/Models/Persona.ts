import { TipoIdentificacion } from './TipoIdentificacion'

export class Persona {
  PersonaId: number
  Nombres: string
  FechaNacimiento: Date
  Identificacion: string
  Tipo: TipoIdentificacion
}
