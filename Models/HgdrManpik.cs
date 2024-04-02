using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrManpik
{
    public int Id { get; set; }

    public string TeurManpik { get; set; } = null!;

    public int? KodManpikSnir { get; set; }

    public string? Hp { get; set; }

    public virtual ICollection<HgdrNech> HgdrNeches { get; set; } = new List<HgdrNech>();
}
