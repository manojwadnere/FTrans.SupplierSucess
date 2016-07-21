using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for OAHistory table
    /// </summary>
    public class OAHistory : OABase
    {
        /// <summary>
        /// Gets or sets the oa history identifier.
        /// </summary>
        /// <value>
        /// The oa history identifier.
        /// </value>
        public long OAHistoryID { get; set; }

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