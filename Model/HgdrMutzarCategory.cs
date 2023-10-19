using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IHubWebApplication.Model;

public partial class HgdrMutzarCategory
{
    public int Id { get; set; }

    public string TeurCtegory { get; set; } = null!;

    public int? KodSugMutzar { get; set; }

    public decimal? RafTsuaYomit { get; set; }
    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();
  
    public virtual HgdrSugMutzar? KodSugMutzarNavigation { get; set; }
}
