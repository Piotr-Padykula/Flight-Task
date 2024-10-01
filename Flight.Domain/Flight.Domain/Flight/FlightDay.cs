using Flight.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Flight;

public class FlightDay : Entity
{
    public int Id { get; private set; }
    public Flight Flight { get; private set; }
    public TimeOnly StartHour { get; private set; }
    public DayOfWeek DayOfWeek { get; private set; }
    public decimal Price { get; private set; }
    public Tenant.Tenant Tenant { get; private set; }
    private FlightDay(Flight flight, TimeOnly startHour, DayOfWeek dayOfWeek, Tenant.Tenant tenant)
    {
        Flight = flight;
        StartHour = startHour;
        DayOfWeek = dayOfWeek;
        Tenant = tenant;
    }
    public static FlightDay Create(Flight flight, TimeOnly startHour, DayOfWeek dayOfWeek, Tenant.Tenant t)
    {
        //validation
        return new FlightDay(flight, startHour, dayOfWeek, t);
    }
}
