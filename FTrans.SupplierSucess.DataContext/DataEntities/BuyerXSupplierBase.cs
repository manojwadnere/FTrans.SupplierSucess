using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class has common properties of BuyerXSupplier and BuyerXSupplierHistory
    /// </summary>
    public class BuyerXSupplierBase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the buyer x supplier identifier.
        /// </summary>
        /// <value>
        /// The buyer x supplier identifier.
        /// </value>
        public int BuyerXSupplierID { get; set; }

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
        /// Gets or sets the buyers supplier identifier.
        /// </summary>
        /// <value>
        /// The buyers supplier identifier.
        /// </value>
        public int BuyersSupplierID { get; set; }

        /// <summary>
        /// Gets or sets the funding choice identifier.
        /// </summary>
        /// <value>
        /// The funding choice identifier.
        /// </value>
        public Int16 FundingChoiceID { get; set; }

        /// <summary>
        /// Gets or sets the contract start date.
        /// </summary>
        /// <value>
        /// The contract start date.
        /// </value>
        public DateTime ContractStartDate { get; set; }

        /// <summary>
        /// Gets or sets the contract expiry date.
        /// </summary>
        /// <value>
        /// The contract expiry date.
        /// </value>
        public DateTime ContractExpiryDate { get; set; }

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