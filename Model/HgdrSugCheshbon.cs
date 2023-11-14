using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrSugCheshbon
{
    public short Id { get; set; }

    public string? SugCheshbon { get; set; }

    public virtual ICollection<HgdrCheshbon> HgdrCheshbons { get; set; } = new List<HgdrCheshbon>();
}
