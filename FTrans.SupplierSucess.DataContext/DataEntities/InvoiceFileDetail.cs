using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for InvoiceFile table
    /// </summary>
    public class InvoiceFileDetail : IDataEntity
    {
        /// <summary>
        /// Gets or sets the invoice file detail identifier.
        /// </summary>
        /// <value>
        /// The invoice file detail identifier.
        /// </value>
        public long InvoiceFileDetailID { get; set; }

        /// <summary>
        /// Gets or sets the invoice file identifier.
        /// </summary>
        /// <value>
        /// The invoice file identifier.
        /// </value>
        public long InvoiceFileID { get; set; }

        /// <summary>
        /// Gets or sets the buyers supplier identifier.
        /// </summary>
        /// <value>
        /// The buyers supplier identifier.
        /// </value>
        public int BuyersSupplierID { get; set; }

        /// <summary>
        /// Gets or sets the buyers supplier invoice number.
        /// </summary>
        /// <value>
        /// The buyers supplier invoice number.
        /// </value>
        public string BuyersSupplierInvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the invoice amount.
        /// </summary>
        /// <value>
        /// The invoice amount.
        /// </value>
        public decimal InvoiceAmount { get; set; }

        /// <summary>
        /// Gets or sets the invoice date.
        /// </summary>
        /// <value>
        /// The invoice date.
        /// </value>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>
        /// The due date.
        /// </value>
        public DateTime DueDate { get; set; }
    }
}