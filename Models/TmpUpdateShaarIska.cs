using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpUpdateShaarIska
{
    public string? KodNeches { get; set; }

    public string? KodNechesBasis { get; set; }

    public DateTime? TaarichIska { get; set; }

    public int? ConvKodNeches { get; set; }

    public int? ConvKodNechesBasis { get; set; }

    public DateTime? CopyOfTaarichIska { get; set; }

    public double? Shaar { get; set; }

    public double? ShaarNb { get; set; }
}
