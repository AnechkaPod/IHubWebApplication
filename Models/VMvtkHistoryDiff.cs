using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvtkHistoryDiff
{
    public decimal? Mishkal { get; set; }

    public int? KodSugMishkal { get; set; }

    public string? TeurSugModel { get; set; }

    public int? KodSugModel { get; set; }

    public string? Neches { get; set; }

    public string? KodNeches { get; set; }

    public string? Remark { get; set; }

    public DateTime? DateTime { get; set; }

    public string? TeurTatAfik { get; set; }

    public string? Afik { get; set; }

    public string? KodTikModel { get; set; }

    public string Src { get; set; } = null!;
}
