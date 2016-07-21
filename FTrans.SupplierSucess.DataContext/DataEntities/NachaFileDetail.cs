using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for NachaFileDetail table
    /// </summary>
    public class NachaFileDetail : IDataEntity
    {
        /// <summary>
        /// Gets or sets the nacha file detail identifier.
        /// </summary>
        /// <value>
        /// The nacha file detail identifier.
        /// </value>
        public long NachaFileDetailID { get; set; }

        /// <summary>
        /// Gets or sets the nacha file identifier.
        /// </summary>
        /// <value>
        /// The nacha file identifier.
        /// </value>
        public long NachaFileID { get; set; }
    }
}