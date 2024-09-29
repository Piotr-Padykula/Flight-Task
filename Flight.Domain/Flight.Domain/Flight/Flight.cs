using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Flight;


public class TicketDiscountHistory
{
    public int ID { get; set; }
    public TicketSold Ticket { get; set; }
    public IEnumerable<DiscountCriteria> DiscountCriteria { get; set; }
}
public class TicketSold
{
    public int ID { get; set; }
    public FlightDay Flight { get; set; }
    public string Client { get; set; }
    public TicketDiscountHistory? TicketHistory { get; set; }
}

public class DiscountCriteria
{
    public int Id { get; set; }
    public string Type { get; set; }

}
public class Tenant
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Flight
{
    public int Id { get; set; }
    public FlightId FlightId { get; private set; }
    public string From { get; private set; }
    public string To { get; private set; }
    public TimeOnly StartHour { get; set; }
    public IEnumerable<FlightDay> FlightDays { get; private set; }
}

public class FlightDay
{
    public int Id { get; set; }
    public Flight Flight { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public Tenant Tenant { get; set; }
}
public class FlightPrice
{
    public int Id { get; set; }
    public FlightDay Day { get; set; }
    public decimal Price { get; set; }

}

public record FlightId
{
    public string Id { get; set; }
    public FlightId(string newId)
    {
        Id = newId;    
    }
}
