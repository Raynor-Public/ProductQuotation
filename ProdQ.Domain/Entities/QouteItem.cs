using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure;

public partial class QouteItem
{
    public int Id { get; set; }

    public int QouteId { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }
}
