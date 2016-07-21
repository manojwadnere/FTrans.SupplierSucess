using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Core
{
    public interface IContext
    {
        void AddDependency<S, T>() where T : S;

        void AddSinglotonDependency<S, T>(T Object) where T : S;

        T ResolveDependency<T>();

        void AddCache<T>(string TType, string key, T value);

        T GetCache<T>(string TType, string key);

        void RemoveCache<T>(string TType, string key);

        D GetDoamin<D>(IKey key) where D : IDomain;

        IApplicationUser ApplicationUser { get; set; }

        string ConnectionString { get; }
    }


    public class ContextFactory
    {
        static IContext _context;

        public static IContext Current
        {
            get
            {
                return _context;
            }
        }

        public static void Register(IContext context)
        {
            _context = context;
        }
    }


}
