using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChromaZone.Core.Model.Pedidos
{
    public class EstadoTransicion :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public EstadoTransicion()
        {

        }
        public Guid IdEstadoDestino { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EstadoPedido EstadoPedidoDestino { get; set; }
        public List<EstadoPedido> EstadosOrigen { get; }
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
