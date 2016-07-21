using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for InvoiceHistory table
    /// </summary>
    public class InvoiceHistory : InvoiceBase
    {
        /// <summary>
        /// Gets or sets the invoice history identifier.
        /// </summary>
        /// <value>
        /// The invoice history identifier.
        /// </value>
        public long InvoiceHistoryID { get; set; }
    }
}