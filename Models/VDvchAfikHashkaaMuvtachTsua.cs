using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchAfikHashkaaMuvtachTsua
{
    public int? מספרקרן { get; set; }

    public int? מספרמסלול { get; set; }

    public string? מאפייןעיקרי { get; set; }

    public string חודשהנפקתשכבה { get; set; } = null!;

    public string חודשהבדיקה { get; set; } = null!;

    public decimal? שוויהנכסיםבאפיק { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
