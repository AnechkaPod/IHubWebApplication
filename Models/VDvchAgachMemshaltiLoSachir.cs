using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchAgachMemshaltiLoSachir
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםמנפיק { get; set; }

    public string? שםניירערך { get; set; }

    public string? מספרניירערך { get; set; }

    public string סוגמספרניירערך { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string? תאריךרכישה { get; set; }

    public string? דירוג { get; set; }

    public string? שםמדרג { get; set; }

    public string? מטבעפעילות { get; set; }

    public decimal? מחמ { get; set; }

    public string? מועדפדיון { get; set; }

    public string? שיעורריבית { get; set; }

    public string? תשואהלפדיון { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
