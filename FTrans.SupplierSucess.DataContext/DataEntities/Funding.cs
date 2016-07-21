using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for Funding table
    /// </summary>
    public class Funding : IDataEntity
    {
        /// <summary>
        /// Gets or sets the funding identifier.
        /// </summary>
        /// <value>
        /// The funding identifier.
        /// </value>
        public long FundingID { get; set; }

        /// <summary>
        /// Gets or sets the funding available.
        /// </summary>
        /// <value>
        /// The funding available.
        /// </value>
        public decimal FundingAvailable { get; set; }

        /// <summary>
        /// Gets or sets the funded.
        /// </summary>
        /// <value>
        /// The funded.
        /// </value>
        public decimal Funded { get; set; }
    }
}