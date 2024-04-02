using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class Credential
{
    public string Username { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public string Domain { get; set; } = null!;

    public int Id { get; set; }
}
