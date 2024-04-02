using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchNechesProperty
{
    public string KodNeches { get; set; } = null!;

    public string KodNechesNegdi { get; set; } = null!;

    public int AchuzRibitShnatit { get; set; }

    public int Kamut { get; set; }

    public string KodMatbea { get; set; } = null!;
}
