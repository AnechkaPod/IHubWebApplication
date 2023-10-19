using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace IHubWebApplication.Model;

public partial class HgdrSugMutzar
{
    public int Id { get; set; }

    public string? SugMutzar { get; set; }
    public virtual ICollection<HgdrMutzarCategory> HgdrMutzarCategories { get; set; } = new List<HgdrMutzarCategory>();

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();

}
