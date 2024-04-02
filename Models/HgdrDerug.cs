using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrDerug
{
    public int Id { get; set; }

    public string Derug { get; set; } = null!;

    public bool DerugNamuchLocal { get; set; }

    public bool DerugNamuchInt { get; set; }

    public bool NoDerug { get; set; }
}
