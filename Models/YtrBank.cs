using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class YtrBank
{
    public DateTime Taarich { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? TeurNeches { get; set; }

    public string Cheshbon { get; set; } = null!;

    public string SugYitra { get; set; } = null!;

    public decimal? Kamut { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Shovi { get; set; }
}
