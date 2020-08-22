using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.PedidosEstadistica
{
    public class PedidoClienteEstadistica : RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public PedidoClienteEstadistica()
        {

        }
        /// <summary>
        /// Encabezado del pedido
        /// </summary>
        public Guid IdEncabezadoPedido { get; set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string NombreCliente {get ;set;}

        /// <summary>
        /// Fecha en la cuan se proceso
        /// </summary>
        public string FechaProcesamiento { get; set; }

        /// <summary>
        /// Monto total 
        /// </summary>
        public decimal MontoTotal { get; set; }

        /// <summary>
        /// Identificador del usuario
        /// </summary>
        public string IdUsuario { get; set; }
    }
}
