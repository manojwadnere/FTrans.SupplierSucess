using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class servers as data entity for TransactionType table
    /// </summary>
    public class TransactionType : IDataEntity
    {
        /// <summary>
        /// Gets or sets the transaction type identifier.
        /// </summary>
        /// <value>
        /// The transaction type identifier.
        /// </value>
        public Int16 TransactionTypeID { get; set; }

        /// <summary>
        /// Gets or sets the name of the transaction.
        /// </summary>
        /// <value>
        /// The name of the transaction.
        /// </value>
        public string TransactionName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}