﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrTatAfik
{
    public int Id { get; set; }

    public int KodTatAfik { get; set; }

    public string TeurTatAfik { get; set; } = null!;

    public string? TatAfikRama2 { get; set; }

    public string? Afik { get; set; }

    public int? KodAfik { get; set; }

    public bool? NetrulMvtk { get; set; }

    public int? KodHieTatAfik1 { get; set; }

    public virtual HgdrHieTatAfik? KodHieTatAfik1Navigation { get; set; }
}
