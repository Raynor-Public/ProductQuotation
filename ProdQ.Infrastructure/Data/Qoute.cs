using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure.Data;

public partial class Qoute
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public DateOnly? ValidUntil { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateOnly? Createddate { get; set; }

    public int? Createdby { get; set; }

    public virtual ICollection<QouteItem> QouteItems { get; set; } = new List<QouteItem>();
}
