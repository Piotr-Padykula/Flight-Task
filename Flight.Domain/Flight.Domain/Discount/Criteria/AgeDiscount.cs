using Flight.Domain.FlightReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Discount.Criteria;

public class AgeDiscount : IDiscount
{
    public int Id { get; set; }
    public string Type { get; set; }
    public decimal Value { get; set; } = 5;

    public virtual decimal GetDiscount(Ticket t)
    {
        if(t.Passenger.DateOfBirth.Month == t.FlightDate.Month && t.Passenger.DateOfBirth.Day == t.FlightDate.Day)
        {
            return Value;
        }
        return 0;
    }
}
