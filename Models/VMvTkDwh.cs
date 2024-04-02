using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvTkDwh
{
    public int KodTikModel { get; set; }

    public string? TeurTikModel { get; set; }

    public string KodNeches { get; set; } = null!;

    public int? KodAfik { get; set; }

    public decimal? Mishkal { get; set; }

    public string? Afik { get; set; }

    public string? TeurTatAfik { get; set; }

    public string Neches { get; set; } = null!;

    public decimal? Macham { get; set; }

    public int? KodSugModel { get; set; }

    public int KodMediniyut { get; set; }

    public int? KodKvutza { get; set; }
}
