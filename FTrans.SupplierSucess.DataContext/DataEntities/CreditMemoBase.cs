using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class contains common properties of CreditMemo and CreditMemoHistory
    /// </summary>
    public class CreditMemoBase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the credit memo identifier.
        /// </summary>
        /// <value>
        /// The credit memo identifier.
        /// </value>
        public long CreditMemoID { get; set; }

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
        /// Gets or sets the buyers credit memo number.
        /// </summary>
        /// <value>
        /// The buyers credit memo number.
        /// </value>
        public int BuyersCreditMemoNumber { get; set; }

        /// <summary>
        /// Gets or sets the credit memo status.
        /// </summary>
        /// <value>
        /// The credit memo status.
        /// </value>
        public char CreditMemoStatus { get; set; }

        /// <summary>
        /// Gets or sets the credit memo amount.
        /// </summary>
        /// <value>
        /// The credit memo amount.
        /// </value>
        public decimal CreditMemoAmount { get; set; }

        /// <summary>
        /// Gets or sets the credit memo date.
        /// </summary>
        /// <value>
        /// The credit memo date.
        /// </value>
        public DateTime CreditMemoDate { get; set; }

        /// <summary>
        /// Gets or sets the settlement date.
        /// </summary>
        /// <value>
        /// The settlement date.
        /// </value>
        public DateTime SettlementDate { get; set; }

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