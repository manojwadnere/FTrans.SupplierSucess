using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This serves as data entity for AddressHistory table
    /// </summary>
    public class AddressHistory : AddressBase
    {
        /// <summary>
        /// Gets or sets the address history identifier.
        /// </summary>
        /// <value>
        /// The address history identifier.
        /// </value>
        public long AddressHistoryID { get; set; }
    }
}