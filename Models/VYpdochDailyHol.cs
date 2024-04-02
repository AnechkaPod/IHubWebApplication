using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VYpdochDailyHol
{
    public string? Tik { get; set; }

    public string KodNeches { get; set; } = null!;

    public decimal? Shovi { get; set; }
}
