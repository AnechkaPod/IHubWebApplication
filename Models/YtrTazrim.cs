using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class YtrTazrim
{
    public int KodMutzar { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? KodBasisHatzmada { get; set; }

    public decimal? Shovi { get; set; }

    public DateTime Taarich { get; set; }

    public string? Counterparty { get; set; }
}
