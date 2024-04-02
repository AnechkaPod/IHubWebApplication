using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class IndexedViewTnuotRikuzWithPirut
{
    public string KodNeches { get; set; } = null!;

    public short? KodBasisHatzmada { get; set; }

    public DateTime Taarich { get; set; }

    public int KodMutzar { get; set; }

    public short? GroupByFlag { get; set; }

    public decimal? Shovi { get; set; }

    public long? Count { get; set; }
}
