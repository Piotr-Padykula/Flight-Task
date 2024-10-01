using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Shared
{
    public abstract class Entity
    {
        private List<INotification> _domainEvents =  new List<INotification>();
        public List<INotification> DomainEvents  => _domainEvents;

        public void AddDomainEvent(INotification domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(INotification domainEvent)
        {
            _domainEvents?.Remove(domainEvent);
        }
    }
}
