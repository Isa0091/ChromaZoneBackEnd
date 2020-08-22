using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaZone.Core.Eventos
{
    /// <summary>
    /// Indica que un evento debe levantar un domian evemt
    /// </summary>
    public interface IDomainEvent : INotification, IEvent
    {
    }
}
