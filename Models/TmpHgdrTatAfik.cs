using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpHgdrTatAfik
{
    public int Id { get; set; }

    public int? KodTatAfik { get; set; }

    public int? HieTatAfikId { get; set; }

    public int? KodAfik { get; set; }

    public string? TeurAfik { get; set; }

    public string? TeurTatAfik { get; set; }
}
