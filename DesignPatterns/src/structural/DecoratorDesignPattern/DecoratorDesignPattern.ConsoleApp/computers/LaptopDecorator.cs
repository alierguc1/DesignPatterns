using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConsoleApp.computers
{
    public class LaptopDecorator : Laptop
    {
        public virtual void OpenLid()
        {
            // base ile kalıtım aldığı laptop classındaki OpenLid Fonksiyonunu çağırır.
            base.OpenLid();
        }
        public virtual void CloseLid()
        {
            // base ile kalıtım aldığı laptop classındaki CloseLid Fonksiyonunu çağırır.

            base.CloseLid();
        }
    }
}
