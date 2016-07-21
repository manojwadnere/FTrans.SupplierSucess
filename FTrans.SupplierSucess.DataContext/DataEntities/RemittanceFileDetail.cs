using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for RemittanceFileDetail table
    /// </summary>
    public class RemittanceFileDetail : IDataEntity
    {
        /// <summary>
        /// Gets or sets the remittance file detail identifier.
        /// </summary>
        /// <value>
        /// The remittance file detail identifier.
        /// </value>
        public long RemittanceFileDetailID { get; set; }

        /// <summary>
        /// Gets or sets the remittance file identifier.
        /// </summary>
        /// <value>
        /// The remittance file identifier.
        /// </value>
        public long RemittanceFileID { get; set; }

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
        /// Gets or sets the payment amount.
        /// </summary>
        /// <value>
        /// The payment amount.
        /// </value>
        public decimal PaymentAmount { get; set; }
    }
}