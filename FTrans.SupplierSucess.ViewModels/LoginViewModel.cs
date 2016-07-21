using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.ViewModels
{
    public class LoginViewModel
    {
        private string _EmailId;
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }
    }
}
