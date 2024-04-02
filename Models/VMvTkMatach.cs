using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMvTkMatach
{
    public string? TeurTikModel { get; set; }

    public int KodTikModel { get; set; }

    public string? KodNeches { get; set; }

    public string? NechesMakor { get; set; }

    public string? Neches { get; set; }

    public decimal? MishkalMakor { get; set; }

    public decimal? Mishkal { get; set; }

    public string? TeurSugModel { get; set; }

    public int? KodTatAfik { get; set; }

    public short? KodMachshir { get; set; }

    public string? KodNechesKeren { get; set; }

    public decimal? Chasifa { get; set; }

    public decimal? ShoviKeren { get; set; }

    public decimal? ChasifaPiruk { get; set; }

    public string? KodNechesKuvea { get; set; }

    public string? Matbea { get; set; }

    public string? MatbeaMakor { get; set; }

    public string TeurTatAfik { get; set; } = null!;

    public string? TeurTatAfikMakor { get; set; }

    public string? TatAfikRama2 { get; set; }

    public string? Afik { get; set; }

    public string MatbeaRama2 { get; set; } = null!;

    public string? MachshirMigbala { get; set; }

    public string BasisHatzmadaMigbala { get; set; } = null!;

    public string MedinatChasifaMigbala { get; set; } = null!;

    public string KvutzatDerugMigbala { get; set; } = null!;

    public string NoDerugMigbala { get; set; } = null!;

    public string MenyautSikunMigbala { get; set; } = null!;

    public string HulChasifaMigbala { get; set; } = null!;

    public string IsKerenMigbala { get; set; } = null!;

    public string MedinaNischeretMigbala { get; set; } = null!;
}
