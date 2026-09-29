using System;
using System.Collections.Generic;

namespace Inventy_Demo_MVC_Core.models;

public partial class InvoiceDetail
{
    public int InvoiceId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public double? InvoiceAmount { get; set; }

    public int? FkCustomerId { get; set; }

    public virtual TblCustomer? FkCustomer { get; set; }

    public virtual ICollection<TblInvoicePayment> TblInvoicePayments { get; set; } = new List<TblInvoicePayment>();

    public virtual ICollection<TblInvoiceProduct> TblInvoiceProducts { get; set; } = new List<TblInvoiceProduct>();
}
