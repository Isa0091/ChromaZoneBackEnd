using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Catalogos
{
    public class UnidadMedida :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public UnidadMedida()
        {
            Codigo = Guid.NewGuid();
        }
        /// <summary>
        /// Codigo
        /// </summary>
        public Guid Codigo { get; set; }

        /// <summary>
        ///unidad de medida
        /// </summary>
        public string Nombre { get; set; }

        public  TipoTamanio TipoTamanio { get; set; }
        /// <summary>
        /// Alto se la iamgen
        /// </summary>
        public int Alto { get; set; }

        /// <summary>
        /// ancho de la imagen
        /// </summary>
        public int Ancho { get; set; }

        /// <summary>
        /// material
        /// </summary>
        public Guid idMaterial { get; set; }

    }
}
