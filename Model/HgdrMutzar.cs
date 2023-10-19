using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IHubWebApplication.Model;

public partial class HgdrMutzar
{
    public int Id { get; set; }

    public string Mutzar { get; set; } = null!;

    public int KodSugMutzar { get; set; }

    public int? KodMutzarCategory { get; set; }
    //[JsonIgnore]
    public virtual HgdrMutzarCategory? KodMutzarCategoryNavigation { get; set; }
    //[JsonIgnore]
    public virtual HgdrSugMutzar? KodSugMutzarNavigation { get; set; } = null!;
}
