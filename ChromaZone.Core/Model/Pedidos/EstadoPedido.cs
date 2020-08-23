using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Pedidos
{
    public class EstadoPedido : RootEntity
    {	    
        /// <summary>	
        /// Codigo del estado	
        /// </summary>	
        public Guid Codigo { get; set; }
        /// <summary>	
        /// Nombre del estado	
        /// </summary>	
        public string Nombre { get; set; }
    }
}
