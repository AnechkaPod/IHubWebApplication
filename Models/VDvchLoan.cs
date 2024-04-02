using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchLoan
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public int? מספרמזההלווה { get; set; }

    public string סוגמספרמזההלווה { get; set; } = null!;

    public string? שםהלוואה { get; set; }

    public string מספרהלוואה { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string? מאפייןהלוואותמתואמותעבורזכויותמקרקעין { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string? ענףמסחר { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string קונסורציוםסינדיקציה { get; set; } = null!;

    public string? מספרקונסורציוםסינדיקציה { get; set; }

    public string? תאריךהעמדתהלוואה { get; set; }

    public string? דירוג { get; set; }

    public string? שםמדרג { get; set; }

    public string דירוגהלוואההמנפיק { get; set; } = null!;

    public string? מטבעפעילות { get; set; }

    public decimal? מחמ { get; set; }

    public string סוגהריבית { get; set; } = null!;

    public string? שיעורריבית { get; set; }

    public string? סוגהצמדה { get; set; }

    public string? ריביתעוגן { get; set; }

    public string? שיעורתוספתהפחתהלריביתהעוגן { get; set; }

    public string? תשואהלפדיון { get; set; }

    public string? מועדפדיון { get; set; }

    public string? נחיתותחוזית { get; set; }

    public string? סוגבטוחה { get; set; }

    public string? שוויהבטוחותהעומדותכנגדההלוואה { get; set; }

    public decimal? שיעורהבטוחותמהחוב { get; set; }

    public string? מועדעדכוןאחרוןלשוויהבטוחות { get; set; }

    public string? זכותחזרה { get; set; }

    public int? מבנהלוחסילוקין { get; set; }

    public string? יעודהלוואה { get; set; }

    public string? זכותפירעוןמוקדם { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string? שםגורםמשערך { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? תאריךשערוךאחרון { get; set; }

    public string? תאריךאחרוןבונבחנהבפועלירידתערך { get; set; }

    public string? שיעורריביתבגיןאיניצולמסגרתהאשראי { get; set; }

    public decimal? ערךנקוב { get; set; }

    public decimal? שערהלוואה { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public decimal? שוויהוגןבמטבעהפעילות { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string? עלותמופחתתבמטבעהפעילות { get; set; }

    public string? האםסווגכחובבעייתי { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
