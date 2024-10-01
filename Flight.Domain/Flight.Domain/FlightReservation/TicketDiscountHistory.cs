using Flight.Domain.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.FlightReservation;

public class TicketDiscountHistory
{
    public int Id { get; set; }
    public required string DiscountType { get; set; }
}
