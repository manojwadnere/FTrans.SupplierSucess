using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for UserNotification table
    /// </summary>
    public class UserNotification : IDataEntity
    {
        /// <summary>
        /// Gets or sets the user notification identifier.
        /// </summary>
        /// <value>
        /// The user notification identifier.
        /// </value>
        public long UserNotificationID { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public long UserID { get; set; }

        /// <summary>
        /// Gets or sets the notification date.
        /// </summary>
        /// <value>
        /// The notification date.
        /// </value>
        public DateTime NotificationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notification is read.
        /// </summary>
        /// <value>
        /// true if notification is read; otherwise, false.
        /// </value>
        public bool IsRead { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notification is deleted.
        /// </summary>
        /// <value>
        /// true if notification is deleted; otherwise, false.
        /// </value>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets the valid till.
        /// </summary>
        /// <value>
        /// The valid till.
        /// </value>
        public DateTime ValidTill { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public long CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

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