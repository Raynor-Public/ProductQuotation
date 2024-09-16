using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure.Data;

public partial class User
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;

    public string? Fullname { get; set; }

    public DateOnly? Createddate { get; set; }

    public int? Createdby { get; set; }
}
