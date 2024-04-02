using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMatbea
{
    public short Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string KodMatbea { get; set; } = null!;

    public string Matbea { get; set; } = null!;

    public byte Rank { get; set; }

    public string? Ric { get; set; }

    public string? UnderlyingRic { get; set; }

    public decimal? PriceMultiplier { get; set; }

    public virtual ICollection<FoHgdrMadad> FoHgdrMadads { get; set; } = new List<FoHgdrMadad>();

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
