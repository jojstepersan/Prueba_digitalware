using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioData.Model
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Identificacion { get; set; }
        public int TipoIdentificacionId { get; set; }
    }
}
