using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

    public string? NechesMisgeretMishtana { get; set; }

    public string? NechesMisgeretKvua { get; set; }

    public int? KodMedinatChasifa { get; set; }

    public int? KodMedinaNischeret { get; set; }

    public short? KodMachshirNb { get; set; }

    public int? KodTatAfIk { get; set; }

    public string? KodBasisHatzmada { get; set; }

    [JsonIgnore]
    public virtual ICollection<BtzTnuot> BtzTnuots { get; set; } = new List<BtzTnuot>();

    public virtual HgdrCheshbon? CheshbonYaadDefaultNavigation { get; set; }

    public virtual HgdrMachshir? KodMachshirNavigation { get; set; }

    public virtual HgdrMatbea? KodMatbeaNavigation { get; set; }

    [JsonIgnore]
    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
