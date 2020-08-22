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
        /// Identificador de la plantilla
        /// </summary>
        public Guid IdPlantilla { get; set; }

        /// <summary>
        /// url de la imagen asociada al detalle
        /// </summary>
        public Uri UrlArchivo { get; set; }
    }
}
