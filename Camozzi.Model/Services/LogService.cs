using NLog;
using System;

namespace Camozzi.Model.Services
{
    public class LogService: ILog
    {
        protected readonly Logger Log;
        public LogService()
        {
            Log = LogManager.GetCurrentClassLogger();
        }

        public void Error(string text, string ex)
        {
            Log.Error(text,ex);
        }

        public void Warning(string text)
        {
            //log.Warn()
        }
    }
}
