using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvTkHolding
{
    public int KodSugModel { get; set; }

    public int? KodSugMishkal { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public decimal? Mishkal { get; set; }

    public string? TeurSugMishkal { get; set; }

    public string? TeurSugModel { get; set; }

    public int? KodTatAfik { get; set; }

    public string? TatAfik { get; set; }

    public decimal? Macham { get; set; }

    public decimal? DmeiNihul { get; set; }

    public int? KodMedinaNischeret { get; set; }

    public string? Remark { get; set; }
}
