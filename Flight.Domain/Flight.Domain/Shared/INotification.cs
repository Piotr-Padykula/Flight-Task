using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Shared
{
    public interface INotification
    {
        void Notify(string message);   
    }
}
