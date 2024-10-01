using Flight.Domain.FlightReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Discount.Criteria;

public class DestinationDiscount : IDiscount
{
    public int Id { get; set; }
    public string Type { get; set; }
    public decimal Value { get; set; } = 5;

    public decimal GetDiscount(Ticket t)
    {
        if(t.Flight.Flight.To == "Afryka" && t.Flight.DayOfWeek == DayOfWeek.Thursday)
        {
            return Value;
        }
        return 0;
    }
}
