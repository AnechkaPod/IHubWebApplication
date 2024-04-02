using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFctTazrim
{
    public int KodMutzar { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? KodBasisHatzmada { get; set; }

    public decimal? Shovi { get; set; }

    public string? KodYom { get; set; }

    public int RecType { get; set; }

    public decimal? ShoviMutzar { get; set; }
}
