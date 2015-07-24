using NLog;
using System;

namespace Camozzi.Model.Services
{
    public class LogService: ILog
    {
        private readonly Logger _log;
        public LogService()
        {
            _log = LogManager.GetCurrentClassLogger();
        }

        public void Error(string text, string ex)
        {
            _log.Error(text,ex);
        }

        public void Warning(string text)
        {
            //log.Warn()
        }
    }
}
