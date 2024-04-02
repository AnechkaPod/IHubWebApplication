using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrNech
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public int? CheshbonYaadDefault { get; set; }

    public short? KodMachshir { get; set; }

    public short? KodMatbea { get; set; }

    public bool? CancelOrderExport { get; set; }

    public string? NechesMisgeretMishtana { get; set; }

    public string? NechesMisgeretKvua { get; set; }

    public int? KodTatAfik { get; set; }

    public int? KodHieTatAfik1 { get; set; }

    public string? KodBasisHatzmada { get; set; }

    public string? KodBasisHatzmadaNegative { get; set; }

    public int? KodManpik { get; set; }

    public string? Derug { get; set; }

    public int? KodMedinatChasifa { get; set; }

    public int? KodMedinaNischeret { get; set; }

    public int? KodMedinaManpika { get; set; }

    public short? KodMachshirNb { get; set; }

    public int? KodSchirut { get; set; }

    public int? KodAnaf { get; set; }

    public bool? IsSikunMvTk { get; set; }

    public string? Isin { get; set; }

    public string? Ticker { get; set; }

    public DateTime? TaarichHakama { get; set; }

    public decimal? Strike { get; set; }

    public decimal? Multiplier { get; set; }

    public string? KodNechesBasis { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? InterestDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public int? SettlementPeriodMonths { get; set; }

    public int? KodTimeBasis { get; set; }

    public decimal? Interest { get; set; }

    public int? KodCounterParty { get; set; }

    public bool? FixedRateDirection { get; set; }

    public decimal? Spread { get; set; }

    public int? OrigUnits { get; set; }

    public int? InterestType { get; set; }

    public string? Ric { get; set; }

    public int? IdMadad { get; set; }

    public bool? NechesIsraeli { get; set; }

    public bool? NechesRashi { get; set; }

    public bool? CalcTransFlg { get; set; }

    public decimal? ShaarNbYadani { get; set; }

    public string? Sufix { get; set; }

    public string? TickerNb { get; set; }

    public virtual ICollection<FoHgdrMadad> FoHgdrMadads { get; set; } = new List<FoHgdrMadad>();

    public virtual ICollection<HgdrBankNech> HgdrBankNeches { get; set; } = new List<HgdrBankNech>();

    public virtual ICollection<HgdrPitzul> HgdrPitzuls { get; set; } = new List<HgdrPitzul>();

    public virtual ICollection<HmrtNech> HmrtNeches { get; set; } = new List<HmrtNech>();

    public virtual FoHgdrMadad? IdMadadNavigation { get; set; }

    public virtual HgdrMachshir? KodMachshirNavigation { get; set; }

    public virtual HgdrMachshir? KodMachshirNbNavigation { get; set; }

    public virtual HgdrManpik? KodManpikNavigation { get; set; }

    public virtual HgdrMedina? KodMedinaManpikaNavigation { get; set; }

    public virtual HgdrMedina? KodMedinaNischeretNavigation { get; set; }

    public virtual HgdrMedina? KodMedinatChasifaNavigation { get; set; }

    public virtual ICollection<MvTkHolding> MvTkHoldings { get; set; } = new List<MvTkHolding>();

    public virtual ICollection<MvTkHoldingsTik> MvTkHoldingsTiks { get; set; } = new List<MvTkHoldingsTik>();

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
