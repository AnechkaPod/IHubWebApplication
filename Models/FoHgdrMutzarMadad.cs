using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class FoHgdrMutzarMadad
{
    public int IdMadad { get; set; }

    public int KodMutzarCategory { get; set; }

    public decimal? YaadChasifa { get; set; }

    public virtual FoHgdrMadad IdMadadNavigation { get; set; } = null!;

    public virtual HgdrMutzarCategory KodMutzarCategoryNavigation { get; set; } = null!;
}
