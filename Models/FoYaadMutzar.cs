using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class FoYaadMutzar
{
    public int KodMutzar { get; set; }

    public int IdMadad { get; set; }

    public decimal? YaadChasifa { get; set; }

    public int? MutzarCategory { get; set; }

    public virtual FoHgdrMadad IdMadadNavigation { get; set; } = null!;

    public virtual HgdrMutzar KodMutzarNavigation { get; set; } = null!;

    public virtual HgdrMutzarCategory? MutzarCategoryNavigation { get; set; }
}
