using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDhyAmlotBroker
{
    public long Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public string? Matbea { get; set; }

    public string KodCheshbon { get; set; } = null!;

    public string? Cheshbon { get; set; }

    public string? Broker { get; set; }

    public decimal? Shovi { get; set; }

    public DateTime TaarichErech { get; set; }
}
