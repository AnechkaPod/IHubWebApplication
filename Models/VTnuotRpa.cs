using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotRpa
{
    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public decimal? Shovi { get; set; }

    public short? KodTnuoa { get; set; }

    public DateTime? Taarich { get; set; }

    public string? CheshbonMakor { get; set; }

    public string? CheshbonYaad { get; set; }

    public string? Id { get; set; }

    public int Verification { get; set; }

    public string? MisparTik { get; set; }

    public string? Mutzar { get; set; }
}
