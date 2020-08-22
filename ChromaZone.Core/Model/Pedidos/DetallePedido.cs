using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Pedidos
{
    public class DetallePedido :Entity
    {

        /// <summary>
        /// Encabezado al que pertenece este pedido
        /// </summary>
        public Guid IdEncabezadoPedido { get; set; }

        /// <summary>
        /// Identificador de la iamgen del cliente
        /// </summary>
        public Guid IdImagenCliente { get; set; }

        /// <summary>
        /// Monto de esta imagen
        /// </summary>
        public decimal Monto { get; set; }

        /// <summary>
        /// categoria
        /// </summary>
        public Guid IdCategoria { get; set; }
    }
}
