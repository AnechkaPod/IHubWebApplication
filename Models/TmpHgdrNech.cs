using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpHgdrNech
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public int? CheshbonYaadDefault { get; set; }

    public short? KodMachshir { get; set; }

    public short? KodMatbea { get; set; }

    public bool? CancelOrderExport { get; set; }

    public int? KodTatAfik { get; set; }

    public int? KodHieTatAfik1 { get; set; }

    public string? KodBasisHatzmada { get; set; }

    public string? KodBasisHatzmadaNegative { get; set; }

    public int? KodManpik { get; set; }

    public string? Derug { get; set; }

    public int? KodMedinatChasifa { get; set; }

    public int? KodMedinaNischeret { get; set; }

    public int? KodMedinaManpika { get; set; }

    public int? KodMachshirNb { get; set; }

    public int? KodSchirut { get; set; }

    public int? KodAnaf { get; set; }

    public bool? IsSikunMvTk { get; set; }

    public string? NechesMisgeretMishtana { get; set; }

    public string? NechesMisgeretKvua { get; set; }

    public string? Isin { get; set; }

    public string? Ticker { get; set; }

    public decimal? Multiplier { get; set; }

    public decimal? Strike { get; set; }

    public string? KodNechesBasis { get; set; }
}
