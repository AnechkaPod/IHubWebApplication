using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchNechasimOther
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםהנכסהאחר { get; set; }

    public string מספרהנכסהאחר { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? תאריךעסקה { get; set; }

    public string? מטבעפעילות { get; set; }

    public string? תאריךשערוךאחרון { get; set; }

    public decimal? שווימטבעי { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
