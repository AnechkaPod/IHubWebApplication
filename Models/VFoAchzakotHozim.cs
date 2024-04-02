using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoAchzakotHozim
{
    public string? TeurMadad { get; set; }

    public string? Ticker { get; set; }

    public decimal? KamutLeumi { get; set; }

    public decimal? KamutGoldman { get; set; }

    public decimal? KamutTotal { get; set; }

    public string? Hodesh { get; set; }

    public string? Shana { get; set; }

    public int? Month { get; set; }

    public string? Year { get; set; }
}
