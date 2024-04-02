using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrNechesCounterParty
{
    public byte KodSugMutzar { get; set; }

    public string CounterPartyName { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string KodNeches { get; set; } = null!;
}
