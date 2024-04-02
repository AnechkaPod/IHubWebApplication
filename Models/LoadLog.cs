using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class LoadLog
{
    public int LogId { get; set; }

    public string? PackageName { get; set; }

    public string? EventType { get; set; }

    public string? ExecutionId { get; set; }

    public string? PackageId { get; set; }

    public string? SourceName { get; set; }

    public string? SourceId { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorDescription { get; set; }

    public bool? InteractiveMode { get; set; }

    public string? MachineName { get; set; }

    public string? UserName { get; set; }

    public DateTime EventDateTime { get; set; }

    public string? AppDescription { get; set; }
}
