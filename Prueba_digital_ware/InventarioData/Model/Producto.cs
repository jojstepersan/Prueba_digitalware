using System;
using System.Collections.Generic;
using System.Text;

namespace InventarioData.Model
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
