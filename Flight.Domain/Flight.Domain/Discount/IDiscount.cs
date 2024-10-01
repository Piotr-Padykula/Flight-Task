using Flight.Domain.FlightReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Discount
{
    public interface IDiscount
    {
        string Type { get; }
        decimal GetDiscount(Ticket t);
    }
}
