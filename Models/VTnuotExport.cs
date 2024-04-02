using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotExport
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public decimal? ErechNakuv { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Shovi { get; set; }

    public short KodTnuoa { get; set; }

    public short? KodBasisHatzmada { get; set; }

    public DateTime Taarich { get; set; }

    public string? Heara { get; set; }

    public byte? LoadProcessId { get; set; }

    public string? Ref { get; set; }

    public short? GroupByFlag { get; set; }

    public int? KodSapak { get; set; }

    public int? KodKarteset { get; set; }

    public string? Neches { get; set; }

    public bool? CancelOrderExport { get; set; }

    public string? Matbea { get; set; }

    public string? TeurTnuoa { get; set; }

    public string? TeurKarteset { get; set; }

    public string? TeurSapak { get; set; }

    public string? Status { get; set; }

    public int? KodStatus { get; set; }

    public string? LastApproveUser { get; set; }
}
