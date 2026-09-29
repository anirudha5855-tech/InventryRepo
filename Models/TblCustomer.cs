using System;
using System.Collections.Generic;

namespace Inventy_Demo_MVC_Core.models;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? City { get; set; }

    public int? Mobile { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
}
