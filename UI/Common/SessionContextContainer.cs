using FTrans.SupplierSuccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Common
{
    public class HTTPApplicationContextContainer : IStateContextContainer
    {
        public HTTPApplicationContextContainer()
        {

        }
        public void AddVarriable(string VarriableName, object Value)
        {
            HttpContext.Current.Application.Add(VarriableName, Value);
        }

        public object GetVarriable(string VarriableName)
        {
            return HttpContext.Current.Application[VarriableName];
        }

        public object this[string Key]
        {
            get
            {
                return HttpContext.Current.Application[Key];
            }
            set
            {
                HttpContext.Current.Application[Key] = value;
            }
        }

        public object this[int Index]
        {
            get
            {
                return HttpContext.Current.Application[Index];
            }
            set
            {
                var key = HttpContext.Current.Application.Keys[Index];
                HttpContext.Current.Application[key] = value;
            }
        }
    }

    public class HTTPSessionContextContainer : IStateContextContainer
    {
        public HTTPSessionContextContainer()
        {

        }
        public void AddVarriable(string VarriableName, object Value)
        {
            HttpContext.Current.Session.Add(VarriableName, Value);
        }

        public object GetVarriable(string VarriableName)
        {
            return HttpContext.Current.Session[VarriableName];
        }

        public object this[string Key]
        {
            get
            {
                return HttpContext.Current.Session[Key];
            }
            set
            {
                HttpContext.Current.Session[Key] = value;
            }
        }

        public object this[int Index]
        {
            get
            {
                return HttpContext.Current.Session[Index];
            }
            set
            {
                var key = HttpContext.Current.Session.Keys[Index];
                HttpContext.Current.Session[key] = value;
            }
        }
    }
}