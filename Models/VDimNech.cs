using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDimNech
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public int? CheshbonYaadDefault { get; set; }

    public short? KodMachshir { get; set; }

    public short? KodMatbea { get; set; }

    public bool? CancelOrderExport { get; set; }

    public string Machshir { get; set; } = null!;
}
