﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrMatbea
{
    public string KodNeches { get; set; } = null!;

    public string KodMatbea { get; set; } = null!;

    public string Matbea { get; set; } = null!;

    public byte Rank { get; set; }

    public string? Ric { get; set; }

    public string? UnderlyingRic { get; set; }

    public decimal? PriceMultiplier { get; set; }

    public short Id { get; set; }

    public virtual ICollection<HgdrNech> HgdrNeches { get; set; } = new List<HgdrNech>();

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
