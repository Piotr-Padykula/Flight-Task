using Flight.Domain.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.FlightReservation.Repositories;

public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetByFlightId(FlightId id);
    Task<IEnumerable<Ticket>> GetByPassenger(Passenger.Passenger p);
}
