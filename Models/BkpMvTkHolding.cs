using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class BkpMvTkHolding
{
    public int? KodSugModel { get; set; }

    public string? KodNeches { get; set; }

    public int? KodSugMishkal { get; set; }

    public decimal? Mishkal { get; set; }

    public string? Remark { get; set; }

    public string? KodTikModel { get; set; }

    public DateTime? DateTime { get; set; }
}
