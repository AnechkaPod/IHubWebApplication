using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class BsAllShearim
{
    public DateTime Date { get; set; }

    public int Source { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public decimal? Price { get; set; }

    public decimal? PriceYadani { get; set; }

    public DateTime? TaarichIdkunYadani { get; set; }

    public virtual HgdrSourceSystem SourceNavigation { get; set; } = null!;
}
