using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This serves as data entity for Country table
    /// </summary>
    public class Country : IDataEntity
    {
        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        /// <value>
        /// The country identifier.
        /// </value>
        public Int16 CountryID { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>
        /// The name of the country.
        /// </value>
        public string CountryName { get; set; }
    }
}