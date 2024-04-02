using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchAllDatum
{
    public int? מספרקרן { get; set; }

    public string? סוגקרן { get; set; }

    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public byte? KodSugMutzar { get; set; }

    public int? מספרמסלול { get; set; }

    public string? מספרניירערך { get; set; }

    public string סוגמספרניירערך { get; set; } = null!;

    public string KodNechesAd { get; set; } = null!;

    public string מספרעסקהרגל1 { get; set; } = null!;

    public string? מספרעסקהרגל2 { get; set; }

    public string? טיקר { get; set; }

    public string מספרהלוואה { get; set; } = null!;

    public string מספרמזההקרןהשקעה { get; set; } = null!;

    public string מספרהנכסהאחר { get; set; } = null!;

    public string סוגמספרמזההקרןהשקעות { get; set; } = null!;

    public string? שםניירערך { get; set; }

    public string? שםקרןהשקעה { get; set; }

    public string? שםהנכס { get; set; }

    public string? שםהלוואה { get; set; }

    public string? שםהנכסהאחר { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שערפיקדון { get; set; }

    public decimal? שערהלוואה { get; set; }

    public decimal? ShaarMatbea { get; set; }

    public decimal? מחמ { get; set; }

    public string? תשואהלפדיון { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public decimal? שוויהוגןנטובשח { get; set; }

    public decimal? שוויהנכסיםבאפיק { get; set; }

    public decimal? שוויהוגןבמטבעהנסחררגל1 { get; set; }

    public decimal? שוויהוגןבמטבעהנסחררגל2 { get; set; }

    public decimal? שוויהוגןבמטבעהפעילות { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? ערךנקוברגל1 { get; set; }

    public decimal? ערךנקוברגל2 { get; set; }

    public decimal? ערךנקוב { get; set; }

    public decimal? Chasifa { get; set; }

    public short KodSugYitra { get; set; }

    public string? מועדסיוםחוזי { get; set; }

    public string? שםמדרג { get; set; }

    public decimal? שווימטבעי { get; set; }

    public string? שיעורריבית { get; set; }

    public string? שיעורתוספתהפחתהלריביתהעוגן { get; set; }

    public string? מועדפדיון { get; set; }

    public string? תאריךפקיעתפיקדון { get; set; }

    public string? מספרמזההבנק { get; set; }

    public string סוגמספרמזההבנק { get; set; } = null!;

    public string? שםהבנק { get; set; }

    public int? KodAnaf { get; set; }

    public string? TeurAnaf { get; set; }

    public string? Ticker { get; set; }

    public DateTime? TaarichRechisha { get; set; }

    public int? KodTatAfik { get; set; }

    public string? שםמנפיק { get; set; }

    public string? צדנגדיCounterparty { get; set; }

    public short? KodMachshir { get; set; }

    public string? דירוג { get; set; }

    public string? דירוגהבנק { get; set; }

    public string ישראלחול { get; set; } = null!;

    public int? KodMedinatChasifa { get; set; }

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public int? KodSchirut { get; set; }

    public string סטאטוססחירות { get; set; } = null!;

    public string? Machshir { get; set; }

    public string? מטבעפעילות { get; set; }

    public string? מטבעפעילותרגל1 { get; set; }

    public string? Afik { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public decimal? שיעורמנכסיאפיקההשקעהרגל1 { get; set; }

    public string? שיעורמסךאפיקההשקעהרגל2 { get; set; }

    public int? RegilaLekabel { get; set; }

    public decimal? ShoviKupa { get; set; }

    public string? ענףמסחר { get; set; }

    public string? זירתמסחר { get; set; }

    public int? מבנהלוחסילוקין { get; set; }

    public string? KodRibitOgen { get; set; }

    public string קונסורציוםסינדיקציה { get; set; } = null!;

    public string? מועדההתקשרותבעסקה { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string גורםמצטט { get; set; } = null!;

    public string? ריביתעוגן { get; set; }

    public decimal? יחסהמרה { get; set; }

    public decimal? שערמימוש { get; set; }

    public decimal? שערחליפין { get; set; }

    public string חודשהנפקתשכבה { get; set; } = null!;

    public string חודשהבדיקה { get; set; } = null!;

    public string? שיעורמערךנקובמונפק { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? תאריךהעמדתמסגרתאשראי { get; set; }

    public string? תאריךהעמדתהלוואה { get; set; }

    public string? תאריךפקיעה { get; set; }

    public string דירוגניירהערךהמנפיק { get; set; } = null!;

    public string דירוגהלוואההמנפיק { get; set; } = null!;

    public string סוגהריבית { get; set; } = null!;

    public string? נכסבסיסכתבאופציה { get; set; }

    public string? שיעורריביתבגיןאיניצולמסגרתהאשראי { get; set; }

    public decimal? יתרתהמחויבותלתקופתהדיווחבמטבעהדיווחשלקרןההשקעה { get; set; }

    public decimal? סכוםהמחויבותהראשוניבמטבעהדיווחשלקרןההשקעה { get; set; }

    public decimal? שיעוריתרתהמחויבות { get; set; }

    public decimal? יתרתהמחויבותלתקופתהדיווחבשח { get; set; }

    public decimal? סכוםהמחויבותהראשוניבשח { get; set; }

    public string? שיעורהחזקהבקרןהשקעה { get; set; }

    public string? תאריךהעמדתהתחייבותלקרןהשקעה { get; set; }

    public string? תאריךפקיעתמחויבותלהשקעה { get; set; }

    public decimal? Navבמטבעהדיווחשלקרןההשקעה { get; set; }

    public string שיעורריביתעוגן { get; set; } = null!;

    public string? מטבעפעילותרגל2 { get; set; }

    public DateTime? TaarichShiaruchAcharon { get; set; }

    public DateTime Taarich { get; set; }

    public string? מדינתהתאגדותקרןהשקעה { get; set; }

    public string נספחהתחשבנותבטחונותCsa { get; set; } = null!;

    public string? קודנכסהלוואתמקור { get; set; }

    public double? ShaarIska { get; set; }

    public double? שערנכסהבסיסבמועדההתקשרותבעסקה { get; set; }

    public string? Hp { get; set; }

    public int? KodManpikSnir { get; set; }

    public int? IdDvchSheet { get; set; }

    public decimal? Pitzul { get; set; }

    public string? KodNeches { get; set; }

    public string? אסטרטגייתקרןההשקעה { get; set; }

    public string? האםסווגכחובבעייתי { get; set; }

    public string? השיטהשבאמצעותהנקבעשוויהנכס { get; set; }

    public string? זכותחזרה { get; set; }

    public string? זכותפירעוןמוקדם { get; set; }

    public string? יעודהלוואה { get; set; }

    public string? כתובתהנכס { get; set; }

    public string? מאפייןהלוואותמתואמותעבורזכויותמקרקעין { get; set; }

    public string? מאפייןעיקרי { get; set; }

    public string? מדינתמיקוםנדלן { get; set; }

    public string? מועדעדכוןאחרוןלשוויהבטוחות { get; set; }

    public string? מחזורחייהנכס { get; set; }

    public string? מטבע { get; set; }

    public string? מיקוםמשרדהשותףהכללי { get; set; }

    public string? מסגרתאשראיבמועדהעמדה { get; set; }

    public string? מספרLei { get; set; }

    public string? מספרמזההשותףכלליקרןהשקעות { get; set; }

    public string? מספרנכסיםבמדדנכסייחוסקרנותנאמנות { get; set; }

    public string? מספרקונסורציוםסינדיקציה { get; set; }

    public string? נחיתותחוזית { get; set; }

    public string? נכסבסיס { get; set; }

    public string? סוגבטוחה { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string? סוגהנכס { get; set; }

    public string? סוגהסליקה { get; set; }

    public string? סוגהצמדה { get; set; }

    public string? סוגלוס { get; set; }

    public string? סוגמספרמזההשותףכלליקרןהשקעות { get; set; }

    public string? סיווגהחובכבעייתי { get; set; }

    public string? סיווגהקרן { get; set; }

    public string? סכוםמסגרתהאשראיהראשוניבמטבעהפעילותIHub { get; set; }

    public string? עלותמופחתתבמטבעהפעילות { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string? פקטורמוביל { get; set; }

    public string? פקטורנוסף { get; set; }

    public string? ריביתעוגןלדיווח { get; set; }

    public string? שוויהבטוחותהעומדותכנגדההלוואה { get; set; }

    public string? שווימאזניבשח { get; set; }

    public string? שיטהשיושמהבדיווחהכספי { get; set; }

    public string? שימושעיקריבנכס { get; set; }

    public string? שיעוראחזקהבאמצעישליטה { get; set; }

    public string? שיעורהקנסבגיןיציאהמוקדמתIHub { get; set; }

    public string? שיעורתשואהבפועלבמהלךהרבעון { get; set; }

    public string? שםגורםמשערך { get; set; }

    public string? שםמוסתר { get; set; }

    public string? שםשותףכלליקרןהשקעות { get; set; }

    public string? שערהנגזרבמועדההתקשרותבעסקהIHub { get; set; }

    public string? שערנכסהבסיסבמועדההתקשרותבעסקהIHub { get; set; }

    public string? תאורמדדנכסייחוסקרנותנאמנות { get; set; }

    public string? תאריךאחרוןבונבחנהבפועלירידתערך { get; set; }

    public string? תאריךעסקה { get; set; }

    public string? תאריךרכישה { get; set; }

    public string? תאריךשערוךאחרוןIHub { get; set; }

    public string? תדירותReset { get; set; }

    public string? תקופתריביתעוגן { get; set; }

    public decimal? YitraLekabel { get; set; }

    public decimal? סכוםלקבלבמטבעהפעילות { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעהרגל1 { get; set; }

    public string? שיעורמסךנכסיההשקעהרגל2 { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? האםקייםקנסבגיןיציאהמוקדמת { get; set; }

    public string? שיעורהקנסבגיןיציאהמוקדמת { get; set; }

    public double? סכוםמסגרתהאשראיהראשוניבמטבעהפעילות { get; set; }

    public double? סכוםמסגרתהאשראיהראשוניבשח { get; set; }

    public string? שיעוריתרתמסגרתאשראי { get; set; }

    public string? תאריךשערוךאחרון { get; set; }

    public decimal? שיעורהבטוחותמהחוב { get; set; }

    public double? שערהנגזרבמועדההתקשרותבעסקה { get; set; }

    public int? מספרמנפיק { get; set; }

    public int? מספרמזההלווה { get; set; }

    public string סוגמספרמזההמנפיק { get; set; } = null!;

    public string סוגמספרמזההלווה { get; set; } = null!;
}
