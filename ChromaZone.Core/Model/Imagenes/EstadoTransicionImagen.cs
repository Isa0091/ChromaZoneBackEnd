using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChromaZone.Core.Model.Imagenes
{
    public class EstadoTransicionImagen :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public EstadoTransicionImagen()
        {

        }
        public Guid IdEstadoDestino { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EstadoImagen EstadoImagenDestino { get; set; }
        public List<EstadoImagen> EstadosOrigen { get; }
        /// <summary>
        /// verifica si el estado origen esta permitido para hacer el cambio al estado destino
        /// </summary>
        /// <param name="idEstadoOrigen"></param>
        /// <returns></returns>
        public bool TransicionPermitida(Guid idEstadoOrigen)
        {
            return EstadosOrigen.Any(z => z.Codigo == idEstadoOrigen);
        }
    }
}
