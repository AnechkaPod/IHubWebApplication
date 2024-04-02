using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VRpaMemshakShovi
{
    public string? MisparTik { get; set; }

    public string? KodCheshbonMatach { get; set; }

    public string? KodCheshbonShekel { get; set; }

    public string? KodCheshbonNiarot { get; set; }

    public string Mutzar { get; set; } = null!;

    public decimal? LastShovi { get; set; }

    public DateTime? LastShoviDate { get; set; }

    public string? TeurCategory { get; set; }

    public string? MisparTikAltshuler { get; set; }

    public int KodMutzar { get; set; }

    public string CheshbonType { get; set; } = null!;

    public string? CheshbonRashi { get; set; }

    public bool? HarigTsuaYomitFlag { get; set; }

    public decimal? RafTsuaYomit { get; set; }

    public decimal? RafTsuaChodshit { get; set; }

    public decimal? RafTsuaChodshitHarig { get; set; }

    public int? Metafel { get; set; }
}
