using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// This class servers as data entity for TransactionTypeXAccounts table
    public class TransactionTypeXAccounts : IDataEntity
    {
        /// <summary>
        /// Gets or sets the transaction type x accounts identifier.
        /// </summary>
        /// <value>
        /// The transaction type x accounts identifier.
        /// </value>
        public long TransactionTypeXAccountsID { get; set; }

        /// <summary>
        /// Gets or sets the transaction type identifier.
        /// </summary>
        /// <value>
        /// The transaction type identifier.
        /// </value>
        public Int16 TransactionTypeID { get; set; }

        /// <summary>
        /// Gets or sets the debit acct no.
        /// </summary>
        /// <value>
        /// The debit acct no.
        /// </value>
        public string DebitAcctNo { get; set; }

        /// <summary>
        /// Gets or sets the credit acct no.
        /// </summary>
        /// <value>
        /// The credit acct no.
        /// </value>
        public string CreditAcctNo { get; set; }
    }
}