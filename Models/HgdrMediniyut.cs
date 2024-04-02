using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMediniyut
{
    public int KodMediniyut { get; set; }

    public string TeurMediniyut { get; set; } = null!;

    public string? KodKniya { get; set; }

    public string? KodMechira { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? DmeyNihul { get; set; }
}
