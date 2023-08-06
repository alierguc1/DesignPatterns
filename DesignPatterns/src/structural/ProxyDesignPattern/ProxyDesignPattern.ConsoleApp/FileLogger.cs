using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.ConsoleApp
{
    public class FileLogger : IMyLogger
    {
        public void Log(string message)
        {
            message = $"[{DateTime.Now:dd.MM.yyyy}] - {message}";
            File.AppendAllText(@$"{Environment.CurrentDirectory}\{DateTime.Now:dd.MM.yyyy}_logs.txt", message);
        }

        public void Log(IEnumerable<string> message)
        {
            File.AppendAllText(@$"{Environment.CurrentDirectory}\{DateTime.Now:dd.MM.yyyy}_logs.txt", string.Join(Environment.NewLine,message));
        }
    }
}
