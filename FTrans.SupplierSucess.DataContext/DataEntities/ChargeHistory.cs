using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for ChargeHistory table
    /// </summary>
    public class ChargeHistory : ChargeBase
    {
        /// <summary>
        /// Gets or sets the charge history identifier.
        /// </summary>
        /// <value>
        /// The charge history identifier.
        /// </value>
        public long ChargeHistoryID { get; set; }

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