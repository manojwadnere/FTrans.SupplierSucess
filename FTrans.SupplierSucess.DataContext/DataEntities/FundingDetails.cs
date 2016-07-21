using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for FundingDetail table
    /// </summary>
    public class FundingDetail : IDataEntity
    {
        /// <summary>
        /// Gets or sets the funding detail identifier.
        /// </summary>
        /// <value>
        /// The funding detail identifier.
        /// </value>
        public long FundingDetailID { get; set; }

        /// <summary>
        /// Gets or sets the funding identifier.
        /// </summary>
        /// <value>
        /// The funding identifier.
        /// </value>
        public long FundingID { get; set; }

        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public int BankID { get; set; }

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
        /// Gets or sets the open balance.
        /// </summary>
        /// <value>
        /// The open balance.
        /// </value>
        public decimal OpenBalance { get; set; }

        /// <summary>
        /// Gets or sets the remaining balance.
        /// </summary>
        /// <value>
        /// The remaining balance.
        /// </value>
        public decimal RemainingBalance { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public long CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

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