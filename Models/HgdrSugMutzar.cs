using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrSugMutzar
{
    public byte KodSugMotzar { get; set; }

    public string SugMutzar { get; set; } = null!;

    public virtual ICollection<HgdrMutzarCategory> HgdrMutzarCategories { get; set; } = new List<HgdrMutzarCategory>();

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();
}
