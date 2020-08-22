using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Cuenta
{
    /// <summary>
    /// Cuenta de un usuario en el sistema
    /// </summary>
    public class Usuario :RootEntity
    {
        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public string Idusuario { get; set; }
    }
}
