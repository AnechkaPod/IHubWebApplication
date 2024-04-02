using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TnutRpaVerification
{
    public string KodNeches { get; set; } = null!;

    public string CheshbonMakor { get; set; } = null!;

    public string CheshbonYaad { get; set; } = null!;

    public DateTime Taarich { get; set; }
}
