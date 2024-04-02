using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoExportIshur
{
    public string? TeurCategory { get; set; }

    public string? KodCheshbon { get; set; }

    public string Mutzar { get; set; } = null!;

    public string? TeurMadad { get; set; }

    public string Machshir { get; set; } = null!;

    public short KodMachshir { get; set; }

    public string? Ticker { get; set; }

    public string? Symbol { get; set; }

    public decimal? KamutAfterTnua { get; set; }

    public decimal? ChasifaAfterTnua { get; set; }

    public short? SortCatagory { get; set; }

    public short? SortMutzar { get; set; }

    public bool? NechesRashi { get; set; }
}
