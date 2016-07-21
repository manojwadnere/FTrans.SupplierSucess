using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for ImportanceLevel table
    /// </summary>
    public class ImportanceLevel : IDataEntity
    {
        /// <summary>
        /// Gets or sets the importance level identifier.
        /// </summary>
        /// <value>
        /// The importance level identifier.
        /// </value>
        public Int16 ImportanceLevelID { get; set; }

        /// <summary>
        /// Gets or sets the importance description.
        /// </summary>
        /// <value>
        /// The importance description.
        /// </value>
        public string ImportanceDescription { get; set; }
    }
}