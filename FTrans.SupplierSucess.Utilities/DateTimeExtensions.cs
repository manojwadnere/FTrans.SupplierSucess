using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Utilities
{
    public static class DateTimeExtensions
    {
        public static int GetYearDiffrence(this DateTime date, DateTime toCheck = default(DateTime))
        {
            return new DateTime((toCheck - date).Ticks).Year;
        }
    }
}
