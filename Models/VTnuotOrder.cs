using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotOrder
{
    public string KodNeches { get; set; } = null!;

    public short? KodBasisHatzmada { get; set; }

    public DateTime? Taarich { get; set; }

    public string? CheshbonMakor { get; set; }

    public string? CheshbonMaavar { get; set; }

    public string? CheshbonYaad { get; set; }

    public decimal? Shovi { get; set; }

    public string? Mutzar { get; set; }

    public int? Status { get; set; }

    public string? Neches { get; set; }
}
