using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Reacciones
{
    public class ReaccionImagen :RootEntity
    {
        public ReaccionImagen()
        {
            FechaIngreso = DateTimeOffset.Now;
        }
        /// <summary>
        /// Identificador del encabezado de la imagen a reaccionar
        /// </summary>
        public Guid IdEncabezado { get; set; }
        /// <summary>
        /// Identificador del tipo de reaccion
        /// </summary>
        public Guid IdTipoReaccion { get; set; }
        /// <summary>
        /// Fecha de ingreso del registro
        /// </summary>
        public DateTimeOffset FechaIngreso { get; set; }
    }
}
