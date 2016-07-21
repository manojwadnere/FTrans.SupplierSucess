using FTrans.SupplierSuccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Utilities
{
    public abstract class BaseContextClass
    {
        protected BaseContextClass()
        {

        }

        public virtual void AddDependency<S, T>() where T : S
        {

        }

        public virtual void AddSinglotonDependency<S, T>(T Object) where T : S
        {

        }

        private string GenerateKey(string TType, string key)
        {
            return $"{TType}_{key}";
        }

        public virtual void AddCache<T>(string TType, string key, T value)
        {

        }

        public virtual T GetCache<T>(string TType, string key)
        {
            return default(T);
        }

        public virtual void RemoveCache<T>(string TType, string key)
        {

        }

        public virtual T ResolveDependency<T>()
        {
            return default(T);
        }

        public D GetDoamin<D>(IKey key) where D : IDomain
        {
            return (D)Activator.CreateInstance(typeof(D));
        }

        public IApplicationUser ApplicationUser { get; set; }
        public abstract string ConnectionString { get; }
    }

}
