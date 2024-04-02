using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VYpdoch
{
    public int KodMutzar { get; set; }

    public string Mutzar { get; set; } = null!;

    public short? KodChaverBursa { get; set; }

    public string Bank { get; set; } = null!;

    public int? YezirotKamut { get; set; }

    public decimal? YezirotShovi { get; set; }

    public int? PidyonotKamut { get; set; }

    public decimal? PidyonotShovi { get; set; }

    public DateTime Taarich { get; set; }

    public TimeSpan? Time { get; set; }

    public decimal? YpshoviTotal { get; set; }

    public decimal? YezirotShoviPizul { get; set; }

    public decimal? PidyonotShoviPizul { get; set; }

    public long? YezirotShoviTnout { get; set; }

    public long? PidyonotShoviTnout { get; set; }

    public decimal? YezirotShoviHotz { get; set; }

    public decimal? PidyonotShoviHotz { get; set; }

    public string? KerenMechaka { get; set; }

    public string? Medina { get; set; }

    public string? Menahel { get; set; }

    public string? Tik { get; set; }

    public short? Sort { get; set; }

    public int? KodMetafel { get; set; }

    public string? Metafel { get; set; }

    public bool? NotActive { get; set; }
}
