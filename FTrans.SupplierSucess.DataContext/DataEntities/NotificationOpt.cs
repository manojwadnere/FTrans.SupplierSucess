using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for NotificationOpt table
    /// </summary>
    public class NotificationOpt : IDataEntity
    {
        /// <summary>
        /// Gets or sets the notification opt identifier.
        /// </summary>
        /// <value>
        /// The notification opt identifier.
        /// </value>
        public Int16 NotificationOptID { get; set; }

        /// <summary>
        /// Gets or sets the notification opt description.
        /// </summary>
        /// <value>
        /// The notification opt description.
        /// </value>
        public string NotificationOptDescription { get; set; }
    }
}