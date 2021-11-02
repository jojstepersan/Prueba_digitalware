using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioData.Model
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }

        public decimal Total { get; set; }
    }
}
