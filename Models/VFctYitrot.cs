using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFctYitrot
{
    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public short KodSugYitra { get; set; }

    public int KodTatAfik { get; set; }

    public int KodHieTatAfik1 { get; set; }

    public int? KodMachshir { get; set; }

    public string? KodBasisHatzmada { get; set; }

    public decimal? Kamut { get; set; }

    public decimal? Shovi { get; set; }

    public string? KodYom { get; set; }
}
