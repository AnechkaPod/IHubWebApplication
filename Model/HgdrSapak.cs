using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrSapak
{
    public int Id { get; set; }

    public string TeurSapak { get; set; } = null!;

    public string? SugSherut { get; set; }
}
