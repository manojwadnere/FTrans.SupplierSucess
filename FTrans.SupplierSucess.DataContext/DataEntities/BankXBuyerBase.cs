using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class has common properties of BankXBuyer and BankXBuyerHistory
    /// </summary>
    public class BankXBuyerBase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the bank x buyer identifier.
        /// </summary>
        /// <value>
        /// The bank x buyer identifier.
        /// </value>
        public int BankXBuyerID { get; set; }

        /// <summary>
        /// Gets or sets the bank identifier.
        /// </summary>
        /// <value>
        /// The bank identifier.
        /// </value>
        public int BankID { get; set; }

        /// <summary>
        /// Gets or sets the buyer identifier.
        /// </summary>
        /// <value>
        /// The buyer identifier.
        /// </value>
        public int BuyerID { get; set; }

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