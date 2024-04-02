using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VYtrSnir
{
    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? KodNechesHamara { get; set; }

    public string? Neches { get; set; }

    public string? Ticker { get; set; }

    public decimal? Chasifa { get; set; }

    public decimal? ShoviKeupa { get; set; }

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
}
