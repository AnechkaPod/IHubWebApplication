using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMutzar
{
    public int KodMutzar { get; set; }

    public string Mutzar { get; set; } = null!;

    public byte KodSugMutzar { get; set; }

    public int? KodSugKeren { get; set; }

    public int? Metafel { get; set; }

    public bool? IsKerenMechaka { get; set; }

    public string? Medina { get; set; }

    public string? Menahel { get; set; }

    public short? Sort { get; set; }

    public string? NameForTri { get; set; }

    public int? CheshbonMatach { get; set; }

    public bool? NotActive { get; set; }

    public int? KodMutzarCategory { get; set; }

    public bool? HarigTsuaYomitFlag { get; set; }

    public int? KodOtzar { get; set; }

    public int? KodKvutzatTikim { get; set; }

    public string? KranotProfilChasifa { get; set; }

    public string? KranotBank { get; set; }

    public string? KranotNeeman { get; set; }

    public TimeSpan? KranotShaaYeudaSunday { get; set; }

    public TimeSpan? KranotShaaYeudaMonThu { get; set; }

    public decimal? KranotDmeyNeeman { get; set; }

    public decimal? KranotDmeyNihul { get; set; }

    public int? KranotSugAmlatHafatza { get; set; }

    public decimal? KranotAmlatHafatza { get; set; }

    public decimal? KranotShiurHosafa { get; set; }

    public string? KranotMaslulMas { get; set; }

    public string? KranotEnglishName { get; set; }

    public string? KranotEnglishNameShort { get; set; }

    public string? KranotHebrewNameShort { get; set; }

    public string? KranotMatbeaPidiyonVeErechNakuv { get; set; }

    public DateTime? KranotNihulStartDate { get; set; }

    public string? KranotHeaderAl { get; set; }

    public string? KranotFirstHeader { get; set; }

    public string? KranotSecondHeader { get; set; }

    public string? KranotMisparCheshbon { get; set; }

    public int? KranotMisparTik { get; set; }

    public string? KranotChesbonBrokerageLeumi { get; set; }

    public string? KranotChesbonBrokerageDiscount { get; set; }

    public string? KranotShnatKesafim { get; set; }

    public int? FoKodMutzarCategory { get; set; }

    public virtual HgdrCheshbon? CheshbonMatachNavigation { get; set; }

    public virtual ICollection<FoYaadMutzar> FoYaadMutzars { get; set; } = new List<FoYaadMutzar>();

    public virtual HgdrMutzarCategory? KodMutzarCategoryNavigation { get; set; }

    public virtual HgdrSugKerenMutzar? KodSugKerenNavigation { get; set; }

    public virtual HgdrSugMutzar KodSugMutzarNavigation { get; set; } = null!;

    public virtual HgdrMetafel? MetafelNavigation { get; set; }
}
