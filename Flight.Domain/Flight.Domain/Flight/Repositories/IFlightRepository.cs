using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Flight.Repositories;

public interface IFlightRepository
{
    Task<IEnumerable<FlightDay>> GetFlightsByDestination(string to);
    Task<IEnumerable<FlightDay>> GetFlightsByDestinationAndDayOfWeek(string to, DayOfWeek dow);
    Task AddNewFlight(Flight f);
}
