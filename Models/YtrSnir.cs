using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class YtrSnir
{
    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public short KodSugYitra { get; set; }

    public int KodTatAfik { get; set; }

    public int KodHieTatAfik1 { get; set; }

    public int? KodMachshir { get; set; }

    public string? KodBasisHatzmada { get; set; }

    public string? KodBasisHatzmadaNegative { get; set; }

    public int? KodManpik { get; set; }

    public DateTime? TaarichPkia { get; set; }

    public DateTime Taarich { get; set; }

    public decimal? Kamut { get; set; }

    public decimal? Shovi { get; set; }

    public string? Tik { get; set; }

    public decimal? Chasifa { get; set; }

    public decimal? ChasifaMatbea { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? ShaarMatbeaMakor { get; set; }

    public decimal? Macham { get; set; }

    public decimal? DmeiNihul { get; set; }

    public int? SnirNechesId { get; set; }

    public int? LoadProcessId { get; set; }
}
