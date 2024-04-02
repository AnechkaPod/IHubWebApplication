using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrAdditionalDataSugYeshut
{
    public int KodSugYeshut { get; set; }

    public string SugYeshut { get; set; } = null!;

    public virtual ICollection<HgdrAdditionalDatum> HgdrAdditionalData { get; set; } = new List<HgdrAdditionalDatum>();
}
