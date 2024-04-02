using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrAnaf
{
    public int Id { get; set; }

    public string TeurAnaf { get; set; } = null!;

    public int? KodAnafSnir { get; set; }
}
