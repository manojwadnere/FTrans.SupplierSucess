namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This serves as data entity for BuyerHistory table

    /// </summary>
    public class BuyerHistory : BuyerBase
    {
        /// <summary>
        /// Gets or sets the buyer history identifier.
        /// </summary>
        /// <value>
        /// The buyer history identifier.
        /// </value>
        public long BuyerHistoryID { get; set; }
    }
}