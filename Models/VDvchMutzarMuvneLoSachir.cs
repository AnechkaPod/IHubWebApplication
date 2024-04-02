using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchMutzarMuvneLoSachir
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםמנפיק { get; set; }

    public int? מספרמנפיק { get; set; }

    public string סוגמספרמזההמנפיק { get; set; } = null!;

    public string? שםניירערך { get; set; }

    public string? מספרניירערך { get; set; }

    public string סוגמספרניירערך { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? נכסבסיס { get; set; }

    public string? תאריךרכישה { get; set; }

    public string? דירוג { get; set; }

    public string? שםמדרג { get; set; }

    public string דירוגניירהערךהמנפיק { get; set; } = null!;

    public string? מטבעפעילות { get; set; }

    public decimal? מחמ { get; set; }

    public string? שיעורריבית { get; set; }

    public string? תשואהלפדיון { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? תאריךשערוךאחרון { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
