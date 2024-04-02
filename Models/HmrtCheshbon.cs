using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HmrtCheshbon
{
    public int KodMetafel { get; set; }

    public int KodCheshbon { get; set; }

    public string KodCheshbonMetafel { get; set; } = null!;

    public virtual HgdrCheshbon KodCheshbonNavigation { get; set; } = null!;

    public virtual HgdrMetafel KodMetafelNavigation { get; set; } = null!;
}
