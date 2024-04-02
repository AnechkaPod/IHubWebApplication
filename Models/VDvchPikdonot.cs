using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchPikdonot
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםהבנק { get; set; }

    public string? מספרמזההבנק { get; set; }

    public string סוגמספרמזההבנק { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string? תאריךפקיעתפיקדון { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? דירוגהבנק { get; set; }

    public string? שםמדרג { get; set; }

    public string? מטבעפעילות { get; set; }

    public decimal? מחמ { get; set; }

    public string? שיעורריבית { get; set; }

    public string? תשואהלפדיון { get; set; }

    public decimal? שווימטבעי { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שערפיקדון { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
