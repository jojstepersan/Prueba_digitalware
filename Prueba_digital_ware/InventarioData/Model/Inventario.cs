using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioData.Model
{
    public class Inventario
    {
        public int RowId { get; set; }
        public int ProductoId { get; set; }
        public decimal CantidadExistente { get; set; }
    }
}
