using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dvd:Storage
    {
        public double speedReadandWrite { get; } = 1.32; //1.32 mb per sec
        string type = "DualSide";
    }
}
