using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class contains common properties of SponsorXBank and SponsorXBankHistory
    /// </summary>
    public class SponsorXBankBase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the sponsor x bank identifier.
        /// </summary>
        /// <value>
        /// The sponsor x bank identifier.
        /// </value>
        public int SponsorXBankID { get; set; }

        /// <summary>
        /// Gets or sets the sponsor identifier.
        /// </summary>
        /// <value>
        /// The sponsor identifier.
        /// </value>
        public int SponsorID { get; set; }

        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public int BankID { get; set; }

        /// <summary>
        /// Gets or sets the contract start date.
        /// </summary>
        /// <value>
        /// The contract start date.
        /// </value>
        public DateTime ContractStartDate { get; set; }

        /// <summary>
        /// Gets or sets the contract expiry date.
        /// </summary>
        /// <value>
        /// The contract expiry date.
        /// </value>
        public DateTime ContractExpiryDate { get; set; }

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