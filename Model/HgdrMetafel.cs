using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrMetafel
{
    public int Id { get; set; }

    public string Metafel { get; set; } = null!;

    public string? Email { get; set; }

    public string? Path { get; set; }

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();
}
