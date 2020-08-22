using ChromaZone.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Catalogos
{
    /// <summary>
    /// Categorias
    /// </summary>
    public class Categoria :RootEntity
    {
        public Categoria()
        {
            Codigo = Guid.NewGuid();
        }
        /// <summary>
        /// Identificador de la categoria
        /// </summary>
        public Guid Codigo { get; set; }

        /// <summary>
        /// Nombre de la categoria
        /// </summary>
        public string Nombre { get; set; }
    }
}
