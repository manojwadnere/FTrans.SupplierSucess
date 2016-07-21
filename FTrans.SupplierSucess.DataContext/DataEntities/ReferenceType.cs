using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for ReferenceType table
    /// </summary>
    public class ReferenceType : IDataEntity
    {
        /// <summary>
        /// Gets or sets the reference type identifier.
        /// </summary>
        /// <value>
        /// The reference type identifier.
        /// </value>
        public Int16 ReferenceTypeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the reference type.
        /// </summary>
        /// <value>
        /// The name of the reference type.
        /// </value>
        public string ReferenceTypeName { get; set; }

        /// <summary>
        /// Gets or sets the reference number.
        /// </summary>
        /// <value>
        /// The reference number.
        /// </value>
        public int ReferenceNumber { get; set; }
    }
}