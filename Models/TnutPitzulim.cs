using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TnutPitzulim
{
    public int Id { get; set; }

    public int IdTnuoa { get; set; }

    public int KodMutzar { get; set; }

    public decimal? ErechNakuv { get; set; }

    public decimal? Shaar { get; set; }

    public decimal Shovi { get; set; }

    public virtual TnutTnuot IdTnuoaNavigation { get; set; } = null!;
}
