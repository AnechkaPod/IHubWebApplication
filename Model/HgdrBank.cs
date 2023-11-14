using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrBank
{
    public short KodBank { get; set; }

    public string Bank { get; set; } = null!;

    public short? KodChaverBursa { get; set; }

    public int? KodManpik { get; set; }

    public string? CounterPartyName { get; set; }

    public string? TeurChaverBursaPoalim { get; set; }

    public int? KodBroker { get; set; }

    public virtual ICollection<HgdrCheshbon> HgdrCheshbons { get; set; } = new List<HgdrCheshbon>();
}
