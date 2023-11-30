using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrCheshbon
{
    public int Id { get; set; }

    public string KodCheshbon { get; set; } = null!;

    public string TeurCheshbon { get; set; } = null!;

    public short Snif { get; set; }

    public short? SugCheshbon { get; set; }

    public short KodBank { get; set; }

    public string? KodCheshbonNiarot { get; set; }

    public string? KodCheshbonMatach { get; set; }

    public string? KodCheshbonShekel { get; set; }

    public string? IbanIls { get; set; }

    public string? IbanMatach { get; set; }

    public string? Swift { get; set; }

    public string? Aba { get; set; }

    public string? Bic { get; set; }

    public string? Address { get; set; }

    public string? BeneficiaryBankName { get; set; }

    public string? Ref { get; set; }

    public string? Bsb { get; set; }

    public string? CleaningCode { get; set; }

    public string? Attention { get; set; }

    public string? SortCode { get; set; }

    public int? KodMutzar { get; set; }

    public virtual ICollection<HgdrMachshir> HgdrMachshirs { get; set; } = new List<HgdrMachshir>();

    public virtual ICollection<HgdrMutzar> HgdrMutzars { get; set; } = new List<HgdrMutzar>();

    public virtual ICollection<HgdrNech> HgdrNeches { get; set; } = new List<HgdrNech>();

    public virtual HgdrBank KodBankNavigation { get; set; } = null!;

    public virtual HgdrSugCheshbon? SugCheshbonNavigation { get; set; }
}
