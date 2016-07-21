namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This serves as data entity for table BuyerXSupplierHistory
    /// </summary>
    public class BuyerXSupplierHistory : BuyerXSupplierBase
    {
        /// <summary>
        /// Gets or sets the buyer x supplier history identifier.
        /// </summary>
        /// <value>
        /// The buyer x supplier history identifier.
        /// </value>
        public long BuyerXSupplierHistoryID { get; set; }
    }
}