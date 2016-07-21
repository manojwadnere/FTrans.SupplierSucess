namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class servers as data entity for SupplierHistory table
    /// </summary>
    public class SupplierHistory : SupplierBase
    {
        /// <summary>
        /// Gets or sets the supplier history identifier.
        /// </summary>
        /// <value>
        /// The supplier history identifier.
        /// </value>
        public long SupplierHistoryID { get; set; }
    }
}