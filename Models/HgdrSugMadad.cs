using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrSugMadad
{
    public string? SugMadad { get; set; }

    public int IdSugMadad { get; set; }

    public virtual ICollection<FoHgdrMadad> FoHgdrMadads { get; set; } = new List<FoHgdrMadad>();
}
