using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConsoleApp.computers
{
    public class Computer
    {
        public void Open()
        {
            Console.WriteLine($"Computer is open ! {DateTime.Now:dddd-mm-yyyy}");
        }

        public void Close()
        {
            Console.WriteLine($"Computer is close ! {DateTime.Now:dddd-mm-yyyy}");
        }
    }
}
