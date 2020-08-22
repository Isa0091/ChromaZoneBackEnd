using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Reacciones
{
    /// <summary>
    /// Maneja las reacciones de los usuarios
    /// </summary>
    public class TipoReaccion :RootEntity
    {
        /// <summary>
        /// Identifica el tipo de reaccion
        /// </summary>
        public  Guid Codigo { get; set; }
        /// <summary>
        /// Nombre de la reaccion
        /// </summary>
        public string Nombre { get; set; }
    }
}
