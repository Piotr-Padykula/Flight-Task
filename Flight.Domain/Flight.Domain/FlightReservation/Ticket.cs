using Flight.Domain.Flight;
using Flight.Domain.Shared;
using Flight.Domain.Passenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight.Domain.Discount;

namespace Flight.Domain.FlightReservation;

public class Ticket : Entity
{
    public int Id { get; private set; }
    public DateOnly FlightDate { get; private set; }
    public decimal Price { get; set; }
    public FlightDay Flight { get; private set; }
    public Domain.Passenger.Passenger Passenger { get; private set; }
    public ICollection<TicketDiscountHistory> TicketDiscountHistory { get; private set; } = new List<TicketDiscountHistory>();
    public TicketConfig? TicketConfig { get; private set; }
    private Ticket(DateOnly fd, FlightDay f, Passenger.Passenger p)
    {
        FlightDate = fd;
        Flight = f;
        Passenger = p;
        Price = f.Price;
    }

    public static Ticket Create(DateOnly fd , FlightDay f, Passenger.Passenger p)
    {
        //validation
        return new Ticket(fd,f,p);
    }
    public void CalculatePrice(IEnumerable<IDiscount> discounts)
    {
        foreach (IDiscount criteria in discounts)
        {
            decimal d = criteria.GetDiscount(this);
            decimal newPrice = Price - d;
            if (newPrice < TicketConfig?.MinTicketPrice) 
            {
                break;
            }

            Price = newPrice;

            if (Flight.Tenant.SaveDiscountHistory)
            {
                TicketDiscountHistory.Add(new TicketDiscountHistory { DiscountType = criteria.Type });
            }
        }
    }
}
