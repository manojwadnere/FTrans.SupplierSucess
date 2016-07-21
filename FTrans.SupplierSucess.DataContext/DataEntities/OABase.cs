using System;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class contains common properties of OA and OAHistory
    /// </summary>
    public class OABase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the OAID.
        /// </summary>
        /// <value>
        /// The OAID.
        /// </value>
        public long OAID { get; set; }

        /// <summary>
        /// Gets or sets the buyer identifier.
        /// </summary>
        /// <value>
        /// The buyer identifier.
        /// </value>
        public int BuyerID { get; set; }

        /// <summary>
        /// Gets or sets the supplier identifier.
        /// </summary>
        /// <value>
        /// The supplier identifier.
        /// </value>
        public int SupplierID { get; set; }

        /// <summary>
        /// Gets or sets the remittance file identifier.
        /// </summary>
        /// <value>
        /// The remittance file identifier.
        /// </value>
        public long RemittanceFileID { get; set; }

        /// <summary>
        /// Gets or sets the oa status.
        /// </summary>
        /// <value>
        /// The oa status.
        /// </value>
        public char OAStatus { get; set; }

        /// <summary>
        /// Gets or sets the oa amount.
        /// </summary>
        /// <value>
        /// The oa amount.
        /// </value>
        public decimal OAAmount { get; set; }
    }
}