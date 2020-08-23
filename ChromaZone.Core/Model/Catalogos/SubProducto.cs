using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Catalogos
{
    /// <summary>
    /// Describe las medidas
    /// </summary>
    public class SubProducto :Entity
    {
        /// <summary>
        /// 
        /// </summary>
        public SubProducto()
        {
            Codigo = Guid.NewGuid();
        }
        /// <summary>
        /// Codigo
        /// </summary>
        public Guid Codigo { get; set; }
        /// <summary>
        /// Nombre 
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Unidad de medida
        /// </summary>
        public Guid IdUnidadMedida { get; set; }

        /// <summary>
        /// Material
        /// </summary>
        public  Guid IdMaterial { get; set; }

        public bool Activar { set; get; }
        public decimal Precio { set; get; }
        public decimal PrecioEspecial { set; get; }
    }
}
