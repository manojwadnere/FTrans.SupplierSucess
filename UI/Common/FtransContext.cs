using FTrans.SupplierSuccess.Core;
using FTrans.SupplierSuccess.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace UI.Common
{
    public class FtransContext : BaseContextClass, IContext
    {
        public override string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
        }
    }
}