using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure;

public partial class Quotation
{
    public int QuotationId { get; set; }

    public int CustomerId { get; set; }

    public DateOnly QuotationDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<QuotationItem> QuotationItems { get; set; } = new List<QuotationItem>();
}
