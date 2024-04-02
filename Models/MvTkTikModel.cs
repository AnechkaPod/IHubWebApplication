using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MvTkTikModel
{
    public int KodTikModel { get; set; }

    public string? TeurTikModel { get; set; }

    public int KodSugModel { get; set; }

    public decimal MishkalEquity { get; set; }

    public int KodMediniyut { get; set; }

    public int? KodKvutza { get; set; }

    public bool? NetrulShirshor { get; set; }

    public short? Sort { get; set; }

    public bool? IsHarig { get; set; }

    public virtual MvTkSugModel KodSugModelNavigation { get; set; } = null!;

    public virtual ICollection<MvTkHoldingsTik> MvTkHoldingsTiks { get; set; } = new List<MvTkHoldingsTik>();

    public virtual ICollection<MvTkMigbalot> MvTkMigbalots { get; set; } = new List<MvTkMigbalot>();
}
