namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for CreditMemoHistory table
    /// </summary>
    public class CreditMemoHistory : CreditMemoBase
    {
        /// <summary>
        /// Gets or sets the credit memo history identifier.
        /// </summary>
        /// <value>
        /// The credit memo history identifier.
        /// </value>
        public long CreditMemoHistoryID { get; set; }
    }
}