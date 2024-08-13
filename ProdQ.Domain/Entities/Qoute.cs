using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure;

public partial class Qoute
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public DateOnly? ValidUntil { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateOnly? Createddate { get; set; }

    public int? Createdby { get; set; }
}
