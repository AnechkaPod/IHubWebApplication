using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrHieTatAfik
{
    public int HieTatAfikId { get; set; }

    public string HieTatAfikTeur1 { get; set; } = null!;

    public string HieTatAfikTeur2 { get; set; } = null!;

    public string HieTatAfikTeur3 { get; set; } = null!;

    public string HieTatAfikTeur4 { get; set; } = null!;

    public string HieTatAfikTeur5 { get; set; } = null!;

    public int? HieTatAfikSnirId { get; set; }

    public virtual ICollection<HgdrTatAfik> HgdrTatAfiks { get; set; } = new List<HgdrTatAfik>();
}
