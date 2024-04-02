using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MvTkHolding
{
    public int KodSugModel { get; set; }

    public string KodNeches { get; set; } = null!;

    public int? KodSugMishkal { get; set; }

    public decimal? Mishkal { get; set; }

    public string? Remark { get; set; }

    public virtual HgdrNech KodNechesNavigation { get; set; } = null!;

    public virtual MvTkSugMishkal? KodSugMishkalNavigation { get; set; }

    public virtual MvTkSugModel KodSugModelNavigation { get; set; } = null!;
}
