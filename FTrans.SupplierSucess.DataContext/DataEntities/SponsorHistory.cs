namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class servers as data entity for SponsorHistory table
    /// </summary>
    public class SponsorHistory : SponsorBase
    {
        /// <summary>
        /// Gets or sets the sponsor history identifier.
        /// </summary>
        /// <value>
        /// The sponsor history identifier.
        /// </value>
        public long SponsorHistoryID { get; set; }
    }
}