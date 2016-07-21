using FTrans.SupplierSuccess.Core;
using FTrans.SupplierSuccess.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Domain
{
    public abstract class BaseDomain : IDomain, IDisposable
    {
        protected string ConnectionString;

        private BaseDomain()
        { }

        protected BaseDomain(string connectionString)
        {
            _dataContext = new FTransDBContext(connectionString);
            ConnectionString = connectionString;
        }

        protected BaseDomain(BaseDomain domain)
        {
            _dataContext = domain._dataContext;
        }
      

        public int Save()
        {
            if (ValidateDomainEntity())
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public abstract bool ValidateDomainEntity();
        

        protected FTransDBContext _dataContext;
        private bool _isDisposed;
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _dataContext.Dispose();
                _isDisposed = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}
