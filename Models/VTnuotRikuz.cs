using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotRikuz
{
    public string KodNeches { get; set; } = null!;

    public decimal? Shovi { get; set; }

    public short? KodBasisHatzmada { get; set; }

    public int? Status { get; set; }

    public DateTime? Taarich { get; set; }

    public short? KodTnuoa { get; set; }

    public short? GroupByFlag { get; set; }
}
