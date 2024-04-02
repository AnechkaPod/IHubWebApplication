using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VPitzul
{
    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public int KodMutzar { get; set; }

    public string Mutzar { get; set; } = null!;

    public decimal Pitzul { get; set; }
}
