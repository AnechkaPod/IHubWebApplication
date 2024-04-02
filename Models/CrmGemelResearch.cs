using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class CrmGemelResearch
{
    public string? GenIsin { get; set; }

    public string? GenNumber { get; set; }

    public DateTime? GenNextanalysisdategemel { get; set; }

    public int? GenDebtclassificationgemel { get; set; }

    public int? GenSubject { get; set; }

    public string? GenDescription { get; set; }

    public DateTime? GenUpdatedon { get; set; }
}
