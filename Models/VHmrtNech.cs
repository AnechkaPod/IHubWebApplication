using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VHmrtNech
{
    public int KodMetafel { get; set; }

    public string Metafel { get; set; } = null!;

    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public string KodNechesMetafel { get; set; } = null!;
}
