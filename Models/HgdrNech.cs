using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrNech
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public int? CheshbonYaadDefault { get; set; }

    public short? KodMachsir { get; set; }

    public short? KodMatbea { get; set; }

    public bool? CancelOrderExport { get; set; }

    public string? NechesMisgeretMishtana { get; set; }

    public string? NechesMisgeretKvua { get; set; }

    public int? KodTatAfik { get; set; }
}
