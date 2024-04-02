using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MvTkSugMishkal
{
    public int KodSugMishkal { get; set; }

    public string? TeurSugMishkal { get; set; }

    public virtual ICollection<MvTkHolding> MvTkHoldings { get; set; } = new List<MvTkHolding>();
}
