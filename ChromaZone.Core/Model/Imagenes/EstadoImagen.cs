using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Imagenes
{
    /// <summary>
    /// Maneja los estados de los pedidos
    /// </summary>
    public class EstadoImagen :RootEntity
    {
        /// <summary>
        /// Codigo del estado
        /// </summary>
        public Guid Codigo { get; set; }
        /// <summary>
        /// Nombre del estado
        /// </summary>
        public string Nombre { get; set; }
    }
}
