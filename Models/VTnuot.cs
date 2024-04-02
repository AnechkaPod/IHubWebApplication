using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuot
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Shovi { get; set; }

    public decimal? ErechNakuv { get; set; }

    public short KodTnuoa { get; set; }

    public DateTime Taarich { get; set; }

    public short? KodMatbea { get; set; }

    public string? Matbea { get; set; }

    public string? CheshbonMakor { get; set; }

    public string? CheshbonMaavar { get; set; }

    public string? CheshbonYaad { get; set; }

    public bool? Verification { get; set; }

    public int? KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public int Status { get; set; }

    public int? KodKarteset { get; set; }

    public int? KodSapak { get; set; }
}
