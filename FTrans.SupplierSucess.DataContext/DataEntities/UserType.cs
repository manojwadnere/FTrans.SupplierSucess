using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for UserRole table
    /// </summary>

    public class UserType : IDataEntity
    {
        /// <summary>
        /// Gets or sets the user type identifier.
        /// </summary>
        /// <value>
        /// The user type identifier.
        /// </value>
        public Int16 UserTypeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the user type.
        /// </summary>
        /// <value>
        /// The name of the user type.
        /// </value>
        public string UserTypeName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}