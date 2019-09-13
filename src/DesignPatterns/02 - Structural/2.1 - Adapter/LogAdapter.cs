using System;

namespace DesignPatterns.Adapter
{
    // Adapter class
    public class LogAdapter : ILogger
    {
        public LogAdapter(
            ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        private readonly ILogNetMaster _logNetMaster;

        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}
