using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class AccessoryDecorator : Auto
    {
        IAuto _auto;
        public AccessoryDecorator(IAuto auto) : base(auto.CarName)
        {
            this._auto = auto;
        }
         
    }
}
