using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvTkHoldingsLvl2
{
    public int KodSugModel { get; set; }

    public int? KodSugMishkal { get; set; }

    public decimal? Mishkal { get; set; }

    public string? TeurSugMishkal { get; set; }

    public string? TeurSugModel { get; set; }

    public int? KodTatAfik { get; set; }

    public string? TatAfik { get; set; }

    public decimal? Macham { get; set; }

    public decimal? DmeiNihul { get; set; }
}
