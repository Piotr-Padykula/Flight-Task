using Flight.Domain.Flight.Exceptions;
using Flight.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Flight.Domain.Flight;


public class Flight : Entity
{
    public int Id { get; set; }
    public FlightId FlightId { get; private set; }
    public string From { get; private set; }
    public string To { get; private set; }
    public ICollection<FlightDay> FlightDays { get; private set; }
    public static Flight Create(FlightId id, string from, string to, ICollection<FlightDay> flightDays)
    {
        //validation
        return new Flight { FlightId = id, From = from, To = to, FlightDays = flightDays };
    }
}

public record FlightId
{
    public string Id { get; init; }
    private FlightId(string newId)
    {
        Id = newId;    
    }
    public static FlightId Create(string input)
    {
        if (!Validate(input))
        {
            throw new InvalidFlightId("Input does not match flight id pattern.");
        }
        return new FlightId(input);
    }
    static bool Validate(string input)
    {
        if(input == null) return false;
        if(string.IsNullOrEmpty(input)) return false;
        Regex r = new Regex("^[A-Z]{3}[0-9]{5}[A-Z]{3}$");
        return r.Match(input).Success;
    }
}
