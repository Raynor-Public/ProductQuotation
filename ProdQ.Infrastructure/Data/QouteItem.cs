using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure.Data;

public partial class QouteItem
{
    public int Id { get; set; }

    public int QouteId { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Qoute Qoute { get; set; } = null!;
}
