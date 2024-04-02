using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrSugCheshbon
{
    public short Id { get; set; }

    public string SugCheshbon { get; set; } = null!;

    public virtual ICollection<HgdrCheshbon> HgdrCheshbons { get; set; } = new List<HgdrCheshbon>();
}
