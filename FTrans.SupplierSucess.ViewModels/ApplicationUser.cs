using FTrans.SupplierSuccess.Core;
using FTrans.SupplierSuccess.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.ViewModels
{
    public class ApplicationUser : IViewModel, IApplicationUser
    {
        public int ID { get; set; }

        public Message Message
        {
            get;
            set;
        }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public UserTypes UserTypeID { get; set; }

        public UserRoles UserRole { get; set; }

        public DateTime PasswordChangedDate { get; set; }

        public bool IsPasswordNeeded { get; set; }
    }
}
