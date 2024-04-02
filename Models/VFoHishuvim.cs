using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoHishuvim
{
    public string? TeurMadad { get; set; }

    public int IdMadad { get; set; }

    public int? KodMutzarCategory { get; set; }

    public string? TeurCategory { get; set; }

    public short? SortMutzar { get; set; }

    public short? SortCatagory { get; set; }

    public int KodMutzar { get; set; }

    public string Mutzar { get; set; } = null!;

    public decimal? ShoviKupa { get; set; }

    public string? KodCheshbon { get; set; }

    public int? IdCheshbon { get; set; }

    public short? KodBank { get; set; }

    public string? Bank { get; set; }

    public string? Ticker { get; set; }

    public string? Neches { get; set; }

    public short? KodMachshir { get; set; }

    public int? KodManpik { get; set; }

    public string? TeurManpik { get; set; }

    public decimal Multiplier { get; set; }

    public bool? NechesRashi { get; set; }

    public bool? NechesIsraeli { get; set; }

    public string? CounterPartyName { get; set; }

    public decimal? ShaarNb { get; set; }

    public decimal? ShaarNbYadani { get; set; }

    public decimal? Shaar { get; set; }

    public short? KodMatbea { get; set; }

    public decimal? ShaarMatbea { get; set; }

    public decimal? ChasifaSwap { get; set; }

    public bool? FlgActual { get; set; }

    public decimal? YtrKamut { get; set; }

    public decimal? YtrKamutFutures { get; set; }

    public decimal? YtrKamutEtf { get; set; }

    public decimal? YtrAchuzChasifa { get; set; }

    public decimal? YtrAchuzChasifaFutures { get; set; }

    public decimal? YtrAchuzChasifaEtf { get; set; }

    public decimal? YtrKamutFuturesSal { get; set; }

    public decimal? YtrKamutEtfSal { get; set; }

    public decimal? YtrAchuzChasifaFuturesSal { get; set; }

    public decimal? YtrAchuzChasifaEtfSal { get; set; }

    public decimal? YaadChasifa { get; set; }

    public decimal? HefreshYaadChasifa { get; set; }

    public decimal? KamutYaad { get; set; }

    public decimal? KamutMumlezetFutures { get; set; }

    public decimal? ChasifaFromTnuaMumlezetFutures { get; set; }

    public decimal? ChasifaFromTnuaMumlezetEtf { get; set; }

    public decimal? YitratPaar { get; set; }

    public decimal? HashlamatKamutEtf { get; set; }

    public decimal? ChasifaAfterTnuaMumlezet { get; set; }
}
