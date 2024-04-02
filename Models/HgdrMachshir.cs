using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMachshir
{
    public short Id { get; set; }

    public string Machshir { get; set; } = null!;

    public int? CheshbonDefault { get; set; }

    public int? KodMachshirSnir { get; set; }

    public virtual HgdrCheshbon? CheshbonDefaultNavigation { get; set; }

    public virtual ICollection<FoHgdrMadad> FoHgdrMadads { get; set; } = new List<FoHgdrMadad>();

    public virtual ICollection<HgdrBankNech> HgdrBankNeches { get; set; } = new List<HgdrBankNech>();

    public virtual ICollection<HgdrNech> HgdrNechKodMachshirNavigations { get; set; } = new List<HgdrNech>();

    public virtual ICollection<HgdrNech> HgdrNechKodMachshirNbNavigations { get; set; } = new List<HgdrNech>();
}
