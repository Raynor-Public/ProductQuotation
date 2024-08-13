using System;
using System.Collections.Generic;

namespace ProdQ.Infrastructure;

public partial class Product
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public DateOnly? Createddate { get; set; }

    public int? Createdby { get; set; }
}
