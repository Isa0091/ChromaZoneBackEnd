using ChromaZone.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Imagenes
{
    public class ImagenCliente :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public ImagenCliente()
        {
            Codigo = Guid.NewGuid();
            FechaIngreso = DateTimeOffset.Now;
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
        /// Contiene los datos de la plantilla de la iamgen y la url
        /// </summary>
        public ImagenVO Imagen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IdCliente { get; set; }

        /// <summary>
        /// Categoria
        /// </summary>
        public Guid IdCategoria { get; set; }
        /// <summary>
        /// id encabezado imagen
        /// </summary>
        public Guid IdEncabezadoImagen { get; set; }
        /// <summary>
        /// id producto
        /// </summary>
        public Guid IdProducto { get; set; }
        /// <summary>
        /// id sub-producto
        /// </summary>
        public Guid IdSubProducto { get; set; }
        /// <summary>
        /// Fecha de ingreso del registro
        /// </summary>
        public DateTimeOffset FechaIngreso { get; set; }
    }
}
