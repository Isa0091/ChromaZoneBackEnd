using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.DTO.Categoria
{
    /// <summary>
    /// Datos para modificar la categoria
    /// </summary>
    public class ModificarCategoriaInputDTO
    {
        /// <summary>
        /// Identificador de la categoria
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Nombre de la categoria
        /// </summary>
        public string Nombre { get; set; }
    }
}
