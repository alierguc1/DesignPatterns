using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.ConsoleApp
{
    public interface IMyLogger
    {
        void Log(string message);

        void Log(IEnumerable<string> message);
    }
}
