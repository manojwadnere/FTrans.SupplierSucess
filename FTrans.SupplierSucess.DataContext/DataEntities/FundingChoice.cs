using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for FundingChoice table
    /// </summary>
    public class FundingChoice : IDataEntity
    {
        /// <summary>
        /// Gets or sets the funding choice identifier.
        /// </summary>
        /// <value>
        /// The funding choice identifier.
        /// </value>
        public Int16 FundingChoiceID { get; set; }

        /// <summary>
        /// Gets or sets the funding choice code.
        /// </summary>
        /// <value>
        /// The funding choice code.
        /// </value>
        public string FundingChoiceCode { get; set; }

        /// <summary>
        /// Gets or sets the funding choice description.
        /// </summary>
        /// <value>
        /// The funding choice description.
        /// </value>
        public string FundingChoiceDescription { get; set; }
    }
}