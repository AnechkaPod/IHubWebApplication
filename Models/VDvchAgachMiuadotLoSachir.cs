using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchAgachMiuadotLoSachir
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? מאפייןעיקרי { get; set; }

    public string? שםניירערך { get; set; }

    public string? מספרניירערך { get; set; }

    public string? תאריךרכישה { get; set; }

    public decimal? מחמ { get; set; }

    public string? סוגהצמדה { get; set; }

    public string? מועדפדיון { get; set; }

    public string? שיעורריבית { get; set; }

    public string? תשואהלפדיון { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
