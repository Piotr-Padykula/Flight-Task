using Flight.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Passenger;

public class Passenger : Entity
{
    public int Id { get; set; }
    public required string PassportNo { get; set; }
    public required string FirstName { get; set; }
    public required string Lastname { get; set; }
    public required DateOnly DateOfBirth { get; set; }
}
