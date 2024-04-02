using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvTkMigbalot
{
    public int Id { get; set; }

    public string? TeurTikModel { get; set; }

    public string? TeurSugModel { get; set; }

    public string TeurMigbala { get; set; } = null!;

    public string? TeurMachshir { get; set; }

    public string? TeurBasisHatzmada { get; set; }

    public string? TeurMedinatChasifa { get; set; }

    public string? TeurKvutzatDerug { get; set; }

    public string? TeurLoMedurag { get; set; }

    public string? TeurSikunMenayut { get; set; }

    public string? TeurHulChasifa { get; set; }

    public string? TeurIsKeren { get; set; }

    public string? TeurMedinaNischeret { get; set; }

    public decimal? MaxLimit { get; set; }

    public decimal? MinLimit { get; set; }

    public string? TeurSugMechane { get; set; }

    public string? TeurMakor { get; set; }

    public decimal? AchuzBafual { get; set; }

    public decimal? AchuzMediniyut { get; set; }

    public int Tkinut { get; set; }
}
