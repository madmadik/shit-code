using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int allMemory = 565000;
            int memoryPerFile = 780;
            double time = 0;
            double allStorage = 0;
            ArrayList devices = new ArrayList();
            int menu;

            do
            {
                Console.WriteLine("1-копирование информации на устройства\n2-расчет времени необходимого для копирования\n3-расчет необходимого количества носителей информации представленных типов для переноса информации\n4-расчет общего количества памяти всех устройств\n5-выход\n");
                bool result = int.TryParse(Console.ReadLine(), out menu);

                if(result)
                {
                    switch (menu)
                    {
                        case 1:
                            while (allMemory>memoryPerFile)
                            {
                                Flash flash = new Flash();
                                    flash.name = "sandisk";
                                    flash.model = "ver2.01";
                                    flash.memory = 8000;

                                Dvd dvd = new Dvd();
                                    dvd.name = "pixel";
                                    dvd.model = "y50-70";
                                    dvd.memory = 500;

                                Hdd hdd = new Hdd();
                                    hdd.name = "seagate";
                                    hdd.model = "mark100";
                                    hdd.SetMemory();

                                while(memoryPerFile<flash.GetFreeSpace())
                                { 
                                    flash.AddInfo(memoryPerFile);
                                    allMemory -= memoryPerFile;
                                    time += memoryPerFile / flash.speed;
                                }

                                while(memoryPerFile<dvd.GetFreeSpace())
                                { 
                                    dvd.AddInfo(memoryPerFile);
                                    allMemory -= memoryPerFile;
                                    time += memoryPerFile / dvd.speedReadandWrite;
                                }

                                while(memoryPerFile<hdd.GetFreeSpace())
                                {
                                    hdd.AddInfo(memoryPerFile);
                                    allMemory -= memoryPerFile;
                                    time += memoryPerFile / hdd.speed;
                                }

                                devices.Add(flash);
                                devices.Add(dvd);
                                devices.Add(hdd);
                                allStorage += flash.memory;
                                allStorage += dvd.memory;
                                allStorage += hdd.memory;
                            }

                            Console.Clear();
                            Console.WriteLine("все скопировано!\n");
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("было скопировано за " + time + "секунд\n");
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("количество устройств: " + devices.Count);
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("общее количество памяти - " + allStorage);
                            break;

                        case 5:
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("введите правильно!\n");
                            break;

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("not correctly parsing!");
                }
            }
            while (menu != 5);
            Console.ReadLine();
        }
    }
}
