using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConsoleApp.computers
{
    public class Laptop : Computer
    {
        public void OpenLid()
        {
            Console.WriteLine($"Laptop open lid ! {DateTime.Now:dddd-mm-yyyy}");
        }

        public void CloseLid()
        {
            Console.WriteLine($"Laptop close lid ! {DateTime.Now:dddd-mm-yyyy}");

        }
    }
}
