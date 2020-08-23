using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Imagenes
{
    /// <summary>
    /// Encabezado de los datos de una imagen
    /// </summary>
    public class EncabezadoImagen :RootEntity
    {
        public EncabezadoImagen()
        {
            FechaIngreso = new DateTimeOffset();
            Codigo = Guid.NewGuid();
        }
        /// <summary>
        /// Codigo
        /// </summary>
        public Guid Codigo { get; set; }
        /// <summary>
        /// Nombre de la imagen relacionada
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripcion de el detalle de imagen
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Categoria de la imagen
        /// </summary>
        public int IdCategoria { get; set; }
        /// <summary>
        /// Usuario asociado a este encabezado de imagen
        /// </summary>
        public string IdDisenador { get; set; }

        /// <summary>
        /// Fecha de ingreso del registro
        /// </summary>
        public DateTimeOffset FechaIngreso { get; set; }
        /// <summary>
        /// Id del diseno de la imagen
        /// </summary>
        public Guid IdEstadoImagenDiseno { get; set; }
        /// <summary>
        /// Imagenes asociadas a este encabezado con medidas especificas
        /// </summary>
        public List<DetalleImagen> DetalleImagenes { get; set; }

        public List<HistoricoEstadoImagen> HistoricoEstados { get; set; }
    }
}
