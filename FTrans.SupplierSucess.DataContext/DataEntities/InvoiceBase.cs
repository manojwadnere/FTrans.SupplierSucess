using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class contains common properties of Invoice and InvoiceHistory
    /// </summary>
    public class InvoiceBase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the invoice identifier.
        /// </summary>
        /// <value>
        /// The invoice identifier.
        /// </value>
        public long InvoiceID { get; set; }

        /// <summary>
        /// Gets or sets the buyer identifier.
        /// </summary>
        /// <value>
        /// The buyer identifier.
        /// </value>
        public int BuyerID { get; set; }

        /// <summary>
        /// Gets or sets the supplier identifier.
        /// </summary>
        /// <value>
        /// The supplier identifier.
        /// </value>
        public int SupplierID { get; set; }

        /// <summary>
        /// Gets or sets the buyers supplier invoice number.
        /// </summary>
        /// <value>
        /// The buyers supplier invoice number.
        /// </value>
        public string BuyersSupplierInvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the invoice status.
        /// </summary>
        /// <value>
        /// The invoice status.
        /// </value>
        public char InvoiceStatus { get; set; }

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

        /// <summary>
        /// Gets or sets the payment terms.
        /// </summary>
        /// <value>
        /// The payment terms.
        /// </value>
        public int PaymentTerms { get; set; }

        /// <summary>
        /// Gets or sets the po number.
        /// </summary>
        /// <value>
        /// The po number.
        /// </value>
        public int PONumber { get; set; }

        /// <summary>
        /// Gets or sets the open balance.
        /// </summary>
        /// <value>
        /// The open balance.
        /// </value>
        public decimal OpenBalance { get; set; }

        /// <summary>
        /// Gets or sets the settlement amount.
        /// </summary>
        /// <value>
        /// The settlement amount.
        /// </value>
        public decimal SettlementAmount { get; set; }

        /// <summary>
        /// Gets or sets the settlement date.
        /// </summary>
        /// <value>
        /// The settlement date.
        /// </value>
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or sets the closed date.
        /// </summary>
        /// <value>
        /// The closed.
        /// </value>
        public DateTime Closed { get; set; }

        /// <summary>
        /// Gets or sets the diversity amount.
        /// </summary>
        /// <value>
        /// The diversity.
        /// </value>
        public decimal Diversity { get; set; }

        /// <summary>
        /// Gets or sets the processing amount.
        /// </summary>
        /// <value>
        /// The processing.
        /// </value>
        public decimal Processing
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        /// <value>
        /// The updated by.
        /// </value>
        public long UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the updated date.
        /// </summary>
        /// <value>
        /// The updated date.
        /// </value>
        public DateTime UpdatedDate { get; set; }
    }
}