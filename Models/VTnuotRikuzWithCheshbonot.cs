using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotRikuzWithCheshbonot
{
    public string KodNeches { get; set; } = null!;

    public decimal? Shovi { get; set; }

    public short? KodBasisHatzmada { get; set; }

    public int? Status { get; set; }

    public DateTime? Taarich { get; set; }

    public short? KodTnuoa { get; set; }

    public short? GroupByFlag { get; set; }

    public string? CheshbonMakor { get; set; }

    public string? CheshbonMaavar { get; set; }

    public string? CheshbonYaad { get; set; }

    public string? Mutzar { get; set; }

    public string? Neches { get; set; }

    public int? IdCheshbonMakor { get; set; }

    public int? IdCheshbonMaavar { get; set; }

    public int? IdCheshbonYaad { get; set; }
}
