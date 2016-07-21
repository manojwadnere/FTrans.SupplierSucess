namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class contains common properties of Charge and ChargeHistory
    /// </summary>
    public class ChargeBase
    {
        /// <summary>
        /// Gets or sets the charge identifier.
        /// </summary>
        /// <value>
        /// The charge identifier.
        /// </value>
        public long ChargeID { get; set; }

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
        /// Gets or sets the remittance file identifier.
        /// </summary>
        /// <value>
        /// The remittance file identifier.
        /// </value>
        public long RemittanceFileID { get; set; }

        /// <summary>
        /// Gets or sets the charge status.
        /// </summary>
        /// <value>
        /// The charge status.
        /// </value>
        public char ChargeStatus { get; set; }

        /// <summary>
        /// Gets or sets the charge amount.
        /// </summary>
        /// <value>
        /// The charge amount.
        /// </value>
        public decimal ChargeAmount { get; set; }
    }
}