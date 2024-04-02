using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrSugKerenMutzar
{
    public int KodSugKeren { get; set; }

    public string SugKeren { get; set; } = null!;

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();
}
