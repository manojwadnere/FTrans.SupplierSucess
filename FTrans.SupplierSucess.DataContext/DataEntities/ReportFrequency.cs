using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for ReportFrequency table
    /// </summary>
    public class ReportFrequency : IDataEntity
    {
        /// <summary>
        /// Gets or sets the report frequency identifier.
        /// </summary>
        /// <value>
        /// The report frequency identifier.
        /// </value>
        public Int16 ReportFrequencyID { get; set; }

        /// <summary>
        /// Gets or sets the report frequency code.
        /// </summary>
        /// <value>
        /// The report frequency code.
        /// </value>
        public string ReportFrequencyCode { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}