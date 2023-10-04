﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class Screen
{
    public int Id { get; set; }

    public string? ScreenName { get; set; }

    public int? ScreenParentId { get; set; }

    public int? Order { get; set; }

    public string? RowsUrl { get; set; }

    public string? ColumnsUrl { get; set; }

    public string? ComboDisplayField { get; set; }
}
