using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MvTkSugModel
{
    public int KodSugModel { get; set; }

    public string? TeurSugModel { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<MvTkHolding> MvTkHoldings { get; set; } = new List<MvTkHolding>();

    public virtual ICollection<MvTkTikModel> MvTkTikModels { get; set; } = new List<MvTkTikModel>();
}
