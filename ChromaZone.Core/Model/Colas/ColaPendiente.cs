using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model.Colas
{
    /// <summary>
    /// Clase que sirve para representar una cola que debe procesarse
    /// </summary>
    public class ColaPendiente :RootEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public ColaPendiente()
        {
            FechaCreacion = DateTimeOffset.Now;
        }

        /// <summary>
        /// Llave de la tabla
        /// </summary>
        public int Codigo { get; set; }

        /// <summary>
        /// Id de la session que vamos a utilizar, es un string por lo general
        /// </summary>
        public string IdSession { get; set; }

        /// <summary>
        /// Nombre de la cola, tiene el nombre del root object correspondiente
        /// </summary>
        public string NombreCola { get; set; }

        /// <summary>
        /// El mensaje en JSON que debe encolarse 
        /// </summary>
        public string MensajeJson { get; set; }

        /// <summary>
        /// Fecha en que se creo esta cola en la base para su generacio 
        /// </summary>
        public DateTimeOffset FechaCreacion { get; private set; }
    }
}
