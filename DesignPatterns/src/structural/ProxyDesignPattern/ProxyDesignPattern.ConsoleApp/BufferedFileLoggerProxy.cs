using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.ConsoleApp
{
    public class BufferedFileLoggerProxy : IMyLogger
    {
        private readonly int _logBufferSize;
        private readonly FileLogger _fileLogger;
        private List<string> buffer;

        public BufferedFileLoggerProxy(int logBufferSize)
        {
            _logBufferSize = logBufferSize;
            _fileLogger = new FileLogger();
            buffer = new List<string>(capacity:_logBufferSize);
        }
        public void Log(string message)
        {
            buffer.Add(message);
            if(_logBufferSize <= buffer.Count)
            {
                foreach(var log in buffer)
                {
                    _fileLogger.Log(log);
                    buffer.Clear();
                }
               
            }
        }
        public void Log(IEnumerable<string> message)
        {
            _fileLogger.Log($"{message}");  
        }
    }
}
