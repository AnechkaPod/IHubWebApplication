using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrMachshir
{
    public short Id { get; set; }

    public string Machshir { get; set; } = null!;

    public int? CheshbonDefault { get; set; }

    public int? KodMachshirSnir { get; set; }

    public virtual HgdrCheshbon? CheshbonDefaultNavigation { get; set; }

    public virtual ICollection<HgdrNech> HgdrNeches { get; set; } = new List<HgdrNech>();
}
