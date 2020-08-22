using ChromaZone.Core.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Model
{
    /// <summary>
    /// Clase base heredada por todas las entidades principales de un aggregate
    /// </summary>
    public class RootEntity : Entity
    {
        readonly List<Eventos.IEvent> _eventos;

        /// <summary>
        /// 
        /// </summary>
        public RootEntity()
        {
            _eventos = new List<Eventos.IEvent>();
        }

        /// <summary>
        /// Permite agregar domain events que deben dispararse
        /// </summary>
        /// <param name="evento"></param>
        public void AgregarEvento(Eventos.IEvent evento)
        {
            _eventos.Add(evento);
        }

        /// <summary>
        /// Permite quitar un domain event
        /// </summary>
        /// <param name="evento"></param>
        public void QuitarEvento(IEvent evento)
        {
            _eventos?.Remove(evento);
        }

        /// <summary>
        /// Saca todos los eventos a disparar
        /// </summary>
        public List<IEvent> Eventos => _eventos;
    }
}
