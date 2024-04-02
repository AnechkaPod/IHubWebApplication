using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HmrtNech
{
    public int KodMetafel { get; set; }

    public string KodNeches { get; set; } = null!;

    public string KodNechesMetafel { get; set; } = null!;

    public virtual HgdrMetafel KodMetafelNavigation { get; set; } = null!;

    public virtual HgdrNech KodNechesNavigation { get; set; } = null!;
}
