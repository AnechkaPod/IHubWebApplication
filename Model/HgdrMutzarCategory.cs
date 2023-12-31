﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrMutzarCategory
{
    public int Id { get; set; }

    public string TeurCategory { get; set; } = null!;

    public int? KodSugMutzar { get; set; }

    public decimal? RafTsuaYomit { get; set; }

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();

    public virtual HgdrSugMutzar? KodSugMutzarNavigation { get; set; }
}
