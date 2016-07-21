using FTrans.SupplierSuccess.DataContext.DataEntities;
using FTrans.SupplierSuccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Domain.Mappers
{
    internal static class UserMapper
    {
        public static ApplicationUser ToUserModel(this User entity, ApplicationUser model = null)
        {
            if (model == null)
                model = new ApplicationUser();

            model.FirstName = entity.FirstName;
            model.LastName = entity.LastName;
            model.Email = entity.Email;
            //model.UserTypeID = (UserType)entity.UserTypeID;
            //model.UserRole = entity.UserRole;
            model.PasswordChangedDate = entity.PasswordChangedDate;

            return model;
        }
    }
}
