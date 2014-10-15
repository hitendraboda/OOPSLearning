using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.InterfacePolymorphisam
{
    public class Rectangle: IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Rectangle  - Draw Method");
        }
    }
}
