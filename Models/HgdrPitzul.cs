using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrPitzul
{
    public string KodNeches { get; set; } = null!;

    public int KodMutzar { get; set; }

    public decimal Pitzul { get; set; }

    public virtual HgdrNech KodNechesNavigation { get; set; } = null!;
}
