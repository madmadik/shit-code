using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hdd:Storage
    {
        public int speed { get; } = 480;  //480 mb per sec
        static int numberSectors = 5;
        int[] sectors = new int[numberSectors];

        public void SetMemory()
        {
            for (int i = 0; i < 5; i++)
            {
                Random randomize = new Random();
                sectors[i] = randomize.Next(10, 500);
                memory += sectors[i];
            }
        }



    }
}
