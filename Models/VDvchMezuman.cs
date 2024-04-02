using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchMezuman
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםהבנק { get; set; }

    public string? מספרמזההבנק { get; set; }

    public string סוגמספרמזההבנק { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? דירוגהבנק { get; set; }

    public string? שםמדרג { get; set; }

    public string? מטבעפעילות { get; set; }

    public decimal? שווימטבעי { get; set; }

    public decimal? שערחליפין { get; set; }

    public string? שיעורריבית { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
