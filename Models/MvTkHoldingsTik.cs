using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MvTkHoldingsTik
{
    public int KodTikModel { get; set; }

    public string KodNeches { get; set; } = null!;

    public decimal Mishkal { get; set; }

    public virtual HgdrNech KodNechesNavigation { get; set; } = null!;

    public virtual MvTkTikModel KodTikModelNavigation { get; set; } = null!;
}
