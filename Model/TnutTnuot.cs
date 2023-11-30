using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class TnutTnuot
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public decimal? ErechNakuv { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Shovi { get; set; }

    public short KodTnuoa { get; set; }

    public short? KodBasisHatzmada { get; set; }

    public int Status { get; set; }

    public DateTime Taarich { get; set; }

    public string? Heara { get; set; }

    public byte? LoadProcessId { get; set; }

    public string? Ref { get; set; }

    public short? GroupByFlag { get; set; }

    public int? KodSapak { get; set; }

    public int? KodKarteset { get; set; }

    public virtual HgdrMatbea? KodBasisHatzmadaNavigation { get; set; }

    public virtual HgdrKarteset? KodKartesetNavigation { get; set; }

    public virtual HgdrNech KodNechesNavigation { get; set; } = null!;

    public virtual HgdrSapak? KodSapakNavigation { get; set; }

    public virtual HgdrTnua KodTnuoaNavigation { get; set; } = null!;

    public virtual HgdrTnutStatus StatusNavigation { get; set; } = null!;
}
