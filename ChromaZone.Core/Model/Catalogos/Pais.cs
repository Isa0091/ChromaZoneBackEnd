using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Catalogos
{
    public class Pais : RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Pais()
        {
            Codigo = Guid.NewGuid();
        }
        /// <summary>
        /// Identificador 
        /// </summary>
        public Guid Codigo { get; set; }

        /// <summary>
        /// Nombre 
        /// </summary>
        public string Nombre { get; set; }
    }
}
