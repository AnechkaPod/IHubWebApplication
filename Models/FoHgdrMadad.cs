using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class FoHgdrMadad
{
    public int IdMadad { get; set; }

    public string? TeurMadad { get; set; }

    public int? IdSugMadad { get; set; }

    public short? MachshirNb { get; set; }

    public string? SwapNb { get; set; }

    public short? Matbea { get; set; }

    public virtual ICollection<FoHgdrMutzarMadad> FoHgdrMutzarMadads { get; set; } = new List<FoHgdrMutzarMadad>();

    public virtual ICollection<FoYaadMutzar> FoYaadMutzars { get; set; } = new List<FoYaadMutzar>();

    public virtual ICollection<HgdrNech> HgdrNeches { get; set; } = new List<HgdrNech>();

    public virtual HgdrSugMadad? IdSugMadadNavigation { get; set; }

    public virtual HgdrMachshir? MachshirNbNavigation { get; set; }

    public virtual HgdrMatbea? MatbeaNavigation { get; set; }

    public virtual HgdrNech? SwapNbNavigation { get; set; }
}
