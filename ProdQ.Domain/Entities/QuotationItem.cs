using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure;

public partial class QuotationItem
{
    public int QuotationItemId { get; set; }

    public int QuotationId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Quotation Quotation { get; set; } = null!;
}
