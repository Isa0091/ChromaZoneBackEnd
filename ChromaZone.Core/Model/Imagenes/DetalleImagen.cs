using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Imagenes
{
    public class DetalleImagen : Entity
    {
        /// <summary>
        /// Identificador unico del encabezado
        /// </summary>
        public Guid IdEncabezado { get; set; }
        /// <summary>
        /// dimension de las imagenes
        /// </summary>
        public TamanoImagen TamanoImagen { get; set; }

        /// <summary>
        /// url de la imagen asociada al detalle
        /// </summary>
        public Uri UrlArchivo { get; set; }
    }
}
