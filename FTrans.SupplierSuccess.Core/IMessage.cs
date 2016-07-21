using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Core
{
    public interface IMessage
    {
        string MessageText { get; }
        string MessageCode { get; set; }
        CommunicationStatus MessageStatus { get; set; }

    }

    public enum CommunicationStatus
    {
        Sucess,
        SessionTimeOut,
        BusinessError,
        FaitalError,
    }
}

