using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Resources
{
    public class FTransResources
    {
        public static string ResolveMessages(string MessageCode)
        {
            var message = Messages.ResourceManager.GetString(MessageCode);
            if (string.IsNullOrEmpty(message))
            {
                return "No able to resolve Message Code:" + MessageCode;
            }
            return message;
        }
    }
}
