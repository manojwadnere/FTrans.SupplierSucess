using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class serves as data entity for BankXBuyerHistory table
    /// </summary>
    public class BankXBuyerHistory : BankXBuyerBase
    {
        /// <summary>
        /// Gets or sets the bank x buyer history identifier.
        /// </summary>
        /// <value>
        /// The bank x buyer history identifier.
        /// </value>
        public long BankXBuyerHistoryID { get; set; }
    }
}