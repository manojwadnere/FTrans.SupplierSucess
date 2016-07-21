using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Core
{
    public class Message:IMessage
    {
        public CommunicationStatus MessageStatus { get; set; }
        public string MessageText
        {
            get
            {
                return Resources.FTransResources.ResolveMessages(MessageCode);
            }
        }

        public string MessageCode { get; set; }
    }

    public interface IViewModel
    {
        Message Message { get; set; }
    }
}
