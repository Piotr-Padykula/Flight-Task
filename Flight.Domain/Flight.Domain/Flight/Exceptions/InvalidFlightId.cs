using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Flight.Exceptions;

public class InvalidFlightId : Exception
{
    public InvalidFlightId(string msg) : base(message: msg)
    {
        
    }
}
