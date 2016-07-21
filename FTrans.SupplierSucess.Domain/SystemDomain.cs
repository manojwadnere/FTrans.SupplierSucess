using FTrans.SupplierSuccess.Core;
using FTrans.SupplierSuccess.Domain.Mappers;
using FTrans.SupplierSuccess.Utilities;
using FTrans.SupplierSuccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Domain
{
    public class SystemDomain:BaseDomain
    {

        public SystemDomain():base(ContextFactory.Current.ConnectionString)
        {
        }

        public SystemDomain(BaseDomain domain) : base(domain)
        {

        }

        public ApplicationUser AuthenticateUser(LoginViewModel loginInformation)
        {
            try
            {
                var user = _dataContext.Users.Where(c => c.UserName == loginInformation.EmailId
                                                        && c.Active == true
                                                        && c.Password == loginInformation.Password).FirstOrDefault();

                if (user == null)
                {
                    return new ApplicationUser()
                    {
                        Message = new Message()
                        {
                            MessageStatus = CommunicationStatus.BusinessError,
                            MessageCode = "InValidUser"
                        }
                    };
                }
                else
                {
                    var model = user.ToUserModel();
                    model.Message = new Message() { MessageStatus = CommunicationStatus.Sucess };
                    return model;
                }
            }
            catch (Exception ex)
            {
                LogManager.Logger.WriteErrorEntry(()=>"Fatel Error while User Authentication", ex);
                return new ApplicationUser()
                {
                    Message = new Message()
                    {
                        MessageStatus = CommunicationStatus.BusinessError,
                        MessageCode = "Error"
                    }
                };
            }

        }

        public override bool ValidateDomainEntity()
        {
            return true;
        }
    }
}
