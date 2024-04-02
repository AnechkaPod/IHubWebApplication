using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MgblExclude
{
    public DateTime CreateDate { get; set; }

    public int KodMigbala { get; set; }

    public string KodYeshutMigbala { get; set; } = null!;

    public string KodYeshutKupotMigbala { get; set; } = null!;

    public string Migbala { get; set; } = null!;

    public string YeshutMigbala { get; set; } = null!;

    public string YeshutKupotMigbala { get; set; } = null!;

    public string? ExcludeType { get; set; }

    public DateTime? ExcludeStartDate { get; set; }

    public DateTime? ExcludeEndDate { get; set; }

    public string? ManagerStatus { get; set; }

    public string? ManagerStatusName { get; set; }

    public DateTime? ManagerStatusDate { get; set; }

    public int Id { get; set; }
}
