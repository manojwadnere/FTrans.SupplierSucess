using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.DataContext.DataEntities
{
    /// <summary>
    /// This class contains common properties of Buyer and BuyerHistory
    /// </summary>
    public class BuyerBase : IDataEntity
    {
        /// <summary>
        /// Gets or sets the buyer identifier.
        /// </summary>
        /// <value>
        /// The buyer identifier.
        /// </value>
        public int BuyerID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ach rounting number.
        /// </summary>
        /// <value>
        /// The ach rounting number.
        /// </value>
        public int ACHRountingNumber { get; set; }

        /// <summary>
        /// Gets or sets the bank account number.
        /// </summary>
        /// <value>
        /// The bank account number.
        /// </value>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the diversity pay rate.
        /// </summary>
        /// <value>
        /// The diversity pay rate.
        /// </value>
        public decimal DiversityPayRate { get; set; }

        /// <summary>
        /// Gets or sets the processing rate.
        /// </summary>
        /// <value>
        /// The processing rate.
        /// </value>
        public decimal ProcessingRate { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets the floor for libor rate.
        /// </summary>
        /// <value>
        /// The floor for libor rate.
        /// </value>
        public decimal FloorForLiborRate { get; set; }

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets the report frequency identifier.
        /// </summary>
        /// <value>
        /// The report frequency identifier.
        /// </value>
        public Int16 ReportFrequencyID { get; set; }

        /// <summary>
        /// Gets or sets the financial days to report.
        /// </summary>
        /// <value>
        /// The financial days to report.
        /// </value>
        public Int16 FinancialDaysToReport { get; set; }

        /// <summary>
        /// Gets or sets the reporting period end.
        /// </summary>
        /// <value>
        /// The reporting period end.
        /// </value>
        public DateTime ReportingPeriodEnd { get; set; }

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