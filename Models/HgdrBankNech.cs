using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrBankNech
{
    public short KodBank { get; set; }

    public string KodNeches { get; set; } = null!;

    public short MachshirId { get; set; }

    public virtual HgdrBank KodBankNavigation { get; set; } = null!;

    public virtual HgdrNech KodNechesNavigation { get; set; } = null!;

    public virtual HgdrMachshir Machshir { get; set; } = null!;
}
