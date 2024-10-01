using Flight.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Domain.Tenant;

public class Tenant : Entity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool SaveDiscountHistory { get; set; }
}
