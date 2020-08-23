using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Imagenes
{
    public class HistoricoEstadoImagen :Entity
    {
        public HistoricoEstadoImagen()
        {

        }
        /// <summary>
        /// codigo
        /// </summary>
        public Guid Codigo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IdEstadoOrigen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IdEstadoDestino { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset FechaCambioEstado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Comentario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IdUsuario { get; set; }

        /// <summary>
        /// identificador de la ruta
        /// </summary>
        public Guid IdEncabezadoImagen { get; set; }
        /// <summary>
        /// estado origen del historico
        /// </summary>
        public EstadoImagen EstadoOrigen { get; set; }
        /// <summary>
        /// estado destino del historico
        /// </summary>
        public EstadoImagen EstadoDestino { get; set; }
    }
}
