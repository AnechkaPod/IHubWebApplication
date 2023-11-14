using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrNech
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public int? CheshbonYaadDefault { get; set; }

    public short? KodMachshir { get; set; }

    public short? KodMatbea { get; set; }

    public bool? CanelOrder { get; set; }

    public virtual HgdrCheshbon? CheshbonYaadDefaultNavigation { get; set; }

    public virtual HgdrMachshir? KodMachshirNavigation { get; set; }

    public virtual HgdrMatbea? KodMatbeaNavigation { get; set; }
}
