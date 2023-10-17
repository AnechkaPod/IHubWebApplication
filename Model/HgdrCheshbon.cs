using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrCheshbon
{
    public int Id { get; set; }

    public string KodCheshbon { get; set; } = null!;

    public string TeurCheshbon { get; set; } = null!;

    public short KodBank { get; set; }

    public short Snif { get; set; }

    public short? SugCheshbon { get; set; }
}
