using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Pedidos
{
    public class EncabezadoPedido :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public EncabezadoPedido()
        {
            Codigo = Guid.NewGuid();
            FechaIngreso = DateTimeOffset.Now;
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public Guid Codigo { get; set; }

        /// <summary>
        /// Fecha de ingreso del registro
        /// </summary>
        public DateTimeOffset FechaIngreso { get; set; }
        /// <summary>
        /// Estado actual del pedido
        /// </summary>
        public Guid IdEstado { get; set; }

        /// <summary>
        /// Monto total del pedido
        /// </summary>
        public decimal MontoTotal { get; set; }
        /// <summary>
        /// Estado del pedido
        /// </summary>
        public EstadoPedido EstadoPedido { get; private set; }
        /// <summary>
        /// Detalle asociados a este encabezado
        /// </summary>
        public List<DetallePedido> Detalles { get; private set; }
        /// <summary>
        /// Historico de los cambios de estado para el pedido
        /// </summary>
        public List<HistoricoEstadoPedido> HistoricoEstadoPedidos { get; private set; }
    }
}
