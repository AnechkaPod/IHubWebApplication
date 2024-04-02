using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchNaamLoSachir
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

    public string? ענףמסחר { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? תאריךרכישה { get; set; }

    public string? דירוג { get; set; }

    public string? שםמדרג { get; set; }

    public string דירוגניירהערךהמנפיק { get; set; } = null!;

    public string? מטבעפעילות { get; set; }

    public decimal? מחמ { get; set; }

    public string? סוגהצמדה { get; set; }

    public string? ריביתעוגן { get; set; }

    public string? מועדפדיון { get; set; }

    public string? שיעורריבית { get; set; }

    public string? תשואהלפדיון { get; set; }

    public string? נחיתותחוזית { get; set; }

    public string? האםסווגכחובבעייתי { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? שםגורםמשערך { get; set; }

    public string? תאריךשערוךאחרון { get; set; }

    public string? תאריךאחרוןבונבחנהבפועלירידתערך { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string? עלותמופחתתבמטבעהפעילות { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
