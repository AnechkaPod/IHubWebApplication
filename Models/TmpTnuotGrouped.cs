using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpTnuotGrouped
{
    public string KodNeches { get; set; } = null!;

    public string KodMutzar { get; set; } = null!;

    public string? KodBasisHatzmada { get; set; }

    public DateTime Taarich { get; set; }

    public string? CounterPartyName { get; set; }

    public byte? LoadProcessId { get; set; }

    public decimal? ErechNakuv { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Shovi { get; set; }

    public short KodPeula { get; set; }

    public short? GroupByFlag { get; set; }
}
