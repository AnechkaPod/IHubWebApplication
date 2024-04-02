using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMutzarCategory
{
    public int Id { get; set; }

    public string TeurCategory { get; set; } = null!;

    public byte? KodSugMutzar { get; set; }

    public decimal? RafTsuaYomit { get; set; }

    public decimal? RafTsuaChodshit { get; set; }

    public decimal? RafTsuaChodshitHarig { get; set; }

    public short? Sort { get; set; }

    public bool? Foflg { get; set; }

    public virtual ICollection<FoHgdrMutzarMadad> FoHgdrMutzarMadads { get; set; } = new List<FoHgdrMutzarMadad>();

    public virtual ICollection<FoYaadMutzar> FoYaadMutzars { get; set; } = new List<FoYaadMutzar>();

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();

    public virtual HgdrSugMutzar? KodSugMutzarNavigation { get; set; }
}
