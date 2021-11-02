using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioData.Model
{
    public class Orden
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public decimal CantidadVendida { get; set; }
    }
}
