using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Pedidos
{
    public class EstadoTransicion : RootEntity
    {
        public EstadoTransicion()
        {
            EstadosOrigen = new List<EstadoPedido>();
        }
        public Guid IdEstadoDestino { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public EstadoPedido EstadoPedidoDestino { get; set; }

        public List<EstadoPedido> EstadosOrigen { get; private set; }
    }
}
