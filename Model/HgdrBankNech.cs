using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrBankNech
{
    public short KodBank { get; set; }

    public string KodNeches { get; set; } = null!;

    public short MachshirId { get; set; }
}
