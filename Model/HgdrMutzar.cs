using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrMutzar
{
    public int KodMutzar { get; set; }

    public string Mutzar { get; set; } = null!;

    public int KodSugMutzar { get; set; }

    public int? KodMutzarCategory { get; set; }

    public virtual HgdrMutzarCategory? KodMutzarCategoryNavigation { get; set; }

    public virtual HgdrSugMutzar KodSugMutzarNavigation { get; set; } = null!;
}
