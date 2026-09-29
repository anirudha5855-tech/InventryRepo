using System;
using System.Collections.Generic;

namespace Inventy_Demo_MVC_Core.models;

public partial class TblInvoiceProduct
{
    public int InvoiceProductId { get; set; }

    public int? FkInvoiceId { get; set; }

    public int? FkProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual InvoiceDetail? FkInvoice { get; set; }

    public virtual TblProduct? FkProduct { get; set; }
}
