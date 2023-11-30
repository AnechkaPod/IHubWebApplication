using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrMutzar
{
    public int Id { get; set; }

    public string Mutzar { get; set; } = null!;

    public int KodSugMutzar { get; set; }

    public int? KodMutzarCategory { get; set; }

    public int? KodSugKeren { get; set; }

    public int? Metafel { get; set; }

    public bool? IsKerenMechaka { get; set; }

    public string? Medina { get; set; }

    public string? Menahel { get; set; }

    public short? Sort { get; set; }

    public string? NameForTri { get; set; }

    public int? CheshbonMatach { get; set; }

    public bool? NotActive { get; set; }

    public bool? HarigTsuaYomitFlag { get; set; }

    public int? KodOtzar { get; set; }

    public int? KodKvutzatTikim { get; set; }

    public virtual HgdrCheshbon? CheshbonMatachNavigation { get; set; }

    public virtual ICollection<HgdrMutzar> InverseKodSugKerenNavigation { get; set; } = new List<HgdrMutzar>();

    public virtual HgdrMutzarCategory? KodMutzarCategoryNavigation { get; set; }

    public virtual HgdrMutzar? KodSugKerenNavigation { get; set; }

    public virtual HgdrSugMutzar KodSugMutzarNavigation { get; set; } = null!;

    public virtual HgdrMetafel? MetafelNavigation { get; set; }
}
