using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Catalogos
{
    public class Producto : RootEntity
    {
        public Producto()
        {
            
        }
        /// <summary>
        /// Codigo
        /// </summary>
        public Guid Codigo { get; set; }
        /// <summary>
        ///  A stock-keeping unit (SKU) is a scannable bar code 
        ///  to help vendors automatically track the movement of inventory.
        /// </summary>
        public string Sku { get; set; }
        public string Nombre { get; set; }

        public bool Activar { set; get; }
        /// <summary>
        /// SubProductos
        /// </summary>
        public List<SubProducto> SubProductos { get; private set; }
    }
}
