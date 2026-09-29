using System;
using System.Collections.Generic;

namespace Inventy_Demo_MVC_Core.models;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public double? Rate { get; set; }

    public double? Gst { get; set; }

    public int? StockQuantity { get; set; }

    public virtual ICollection<TblInvoiceProduct> TblInvoiceProducts { get; set; } = new List<TblInvoiceProduct>();
}
