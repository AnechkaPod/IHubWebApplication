using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrManpik
{
    public int Id { get; set; }

    public string TeurManpik { get; set; } = null!;

    public int? KodManpikSnir { get; set; }
}
