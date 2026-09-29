using System;
using System.Collections.Generic;

namespace Inventy_Demo_MVC_Core.models;

public partial class TblInvoicePayment
{
    public int InvoicePaymentId { get; set; }

    public int? FkInvoiceId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? PaymentAmount { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentDescription { get; set; }

    public virtual InvoiceDetail? FkInvoice { get; set; }
}
