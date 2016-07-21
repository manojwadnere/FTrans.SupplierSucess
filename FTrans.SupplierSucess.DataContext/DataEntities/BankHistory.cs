using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This serves as data entity for BankHistory table
    /// </summary>
    public class BankHistory : BankBase
    {
        /// <summary>
        /// Gets or sets the bank history identifier.
        /// </summary>
        /// <value>
        /// The bank history identifier.
        /// </value>
        public long BankHistoryID { get; set; }
    }
}