using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Utilities
{
    public sealed class LogManager
    {
        static object currentLock = new object();
        static LogManager _current;
        public LogManager()
        {

        }

        public static LogManager Logger
        {
            get
            {
                if (_current == null)
                {
                    lock (currentLock)
                    {
                        _current = new LogManager();
                        _current.ConfigureLogger();
                    }
                }

                return _current;
            }
        }

        public void ConfigureLogger()
        {

        }

        public void WriteDegugEntry(Func<string> func)
        {
        }
        public void WriteInfoEntry(Func<string> func) { }
        public void WriteErrorEntry(Func<string> func) { }
        public void WriteErrorEntry(Func<string> func, Exception ex) { }
        public void StartMethodWithRequest<T>(string methodName, T request) { }
        public void StartOutboundRequest<T>(string methodName, T request) { }
        public void ResponseReceived<T>(string methodName, T response) { }
        public void ExceptionCaught(string methodName, string message) { }
    }
}
