using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for UserRole table
    /// </summary>

    public class UserRole : IDataEntity
    {
        /// <summary>
        /// Gets or sets the user role identifier.
        /// </summary>
        /// <value>
        /// The user role identifier.
        /// </value>
        public Int16 UserRoleID { get; set; }

        /// <summary>
        /// Gets or sets the name of the user role.
        /// </summary>
        /// <value>
        /// The name of the user role.
        /// </value>
        public string UserRoleName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}