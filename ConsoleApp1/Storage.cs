using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Storage
    {
        public string name { get; set; }

        public string model { get; set; }

        public double busySpace { get; set; }

        public double memory { get; set; }

        public void AddInfo(double info)
        {
            busySpace += info;
        }

        public double GetFreeSpace()
        {
            return memory - busySpace;
        }

        public void GetFullInfo()
        {
            Console.WriteLine("носитель - " + name+"\nмодель - " +model+"\nзанятое место - "+busySpace+"\nразмер носителя - "+memory+"\nпустое место - "+GetFreeSpace());
        }
        

    }
}
