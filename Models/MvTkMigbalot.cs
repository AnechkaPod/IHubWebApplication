using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MvTkMigbalot
{
    public int Id { get; set; }

    public int KodTikModel { get; set; }

    public string TeurMigbala { get; set; } = null!;

    public string? TeurMachshir { get; set; }

    public string? TeurBasisHatzmada { get; set; }

    public string? TeurMedinatChasifa { get; set; }

    public string? TeurKvutzatDerug { get; set; }

    public string? TeurLoMedurag { get; set; }

    public string? TeurSikunMenayut { get; set; }

    public string? TeurMedinaNischeret { get; set; }

    public string? TeurHulChasifa { get; set; }

    public string? TeurIsKeren { get; set; }

    public decimal? MaxLimit { get; set; }

    public decimal? MinLimit { get; set; }

    public string? TeurSugMechane { get; set; }

    public string? TeurMakor { get; set; }

    public virtual MvTkTikModel KodTikModelNavigation { get; set; } = null!;
}
