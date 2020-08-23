using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model
{
    public enum TipoImagen {

        /// <summary>
        /// Indica que la imagen la realizo un diseñador
        /// </summary>
        Diseno = 0,
        /// <summary>
        /// Indica que la imagen es copia de un diseño
        /// </summary>
        Copia= 1
    }

    /// <summary>
    /// Indica la dimencion
    /// </summary>
    public enum TipoTamanio
    {
        Pixels = 0,
        Milimetros = 1,
        Centimetros = 2,
        pulgadas = 3
    }

    public enum TamanoImagen
    {
        Pequeno = 0,
        Mediano = 1,
        Grande = 2
    }
}
