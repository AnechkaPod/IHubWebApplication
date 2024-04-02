using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrBank
{
    public short KodBank { get; set; }

    public string Bank { get; set; } = null!;

    public short? KodChaverBursa { get; set; }

    public int? KodManpik { get; set; }

    public string? CounterPartyName { get; set; }

    public string? TeurChaverBursaPoalim { get; set; }

    public int? KodBroker { get; set; }

    public bool? IsIsraeli { get; set; }

    public string? DivuachIdentifier { get; set; }

    public virtual ICollection<HgdrBankNech> HgdrBankNeches { get; set; } = new List<HgdrBankNech>();

    public virtual ICollection<HgdrCheshbon> HgdrCheshbons { get; set; } = new List<HgdrCheshbon>();
}
