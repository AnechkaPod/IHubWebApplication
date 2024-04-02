using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvTkNechesProperty
{
    public string KodNeches { get; set; } = null!;

    public int? KodManpik { get; set; }

    public string? TeurTatAfik { get; set; }

    public string? Afik { get; set; }

    public decimal? Macham { get; set; }

    public decimal? DmeiNihul { get; set; }
}
