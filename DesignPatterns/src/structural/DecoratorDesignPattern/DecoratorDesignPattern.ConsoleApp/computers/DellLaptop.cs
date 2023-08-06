using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConsoleApp.computers
{
    public class DellLaptop : LaptopDecorator
    {
        public override void CloseLid()
        {
            Console.WriteLine($"Dell Laptop is sleep mode on ! {DateTime.Now:dddd-MM-yyyy}");
            base.CloseLid();

        }

        public override void OpenLid()
        {
            Console.WriteLine($"Dell Laptop is waking up mode on ! {DateTime.Now:dddd-MM-yyyy}");

            base.OpenLid();
        }
    }
}
