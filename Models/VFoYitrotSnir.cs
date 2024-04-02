using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoYitrotSnir
{
    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public string KodCheshbon { get; set; } = null!;

    public string Snif { get; set; } = null!;

    public string KodBank { get; set; } = null!;

    public string KodNeches { get; set; } = null!;

    public string? KodNechesHamara { get; set; }

    public string? Neches { get; set; }

    public string? Ticker { get; set; }

    public decimal? Chasifa { get; set; }

    public decimal? ShoviKupa { get; set; }

    public decimal? AchuzChasifa { get; set; }

    public byte? KodSugMutzar { get; set; }

    public string? Afik { get; set; }

    public string? TeurTatAfik { get; set; }

    public decimal? Shovi { get; set; }

    public decimal? Kamut { get; set; }

    public short? KodMachshir { get; set; }

    public string? KodNechesBasis { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Multiplier { get; set; }

    public int SugYitraSal { get; set; }

    public DateTime Taarich { get; set; }
}
