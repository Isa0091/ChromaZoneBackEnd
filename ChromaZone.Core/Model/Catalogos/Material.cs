using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Catalogos
{
    /// <summary>
    /// Indica el material
    /// </summary>
    public class Material :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Material()
        {
            Codigo = Guid.NewGuid();
        }
        /// <summary>
        /// Identificador del material
        /// </summary>
        public Guid Codigo { get; set; }

        /// <summary>
        /// Nombre del material
        /// </summary>
        public string Nombre { get; set; }
    }
}
