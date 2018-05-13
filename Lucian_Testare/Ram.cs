using System;
using System.Management;

namespace Lucian_Testare
{
    class Ram
    {
        public static void Placute_Ram()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("Capacity: {0}", queryObj["Capacity"]);
                    Console.WriteLine("Manufacturer: {0}", queryObj["Manufacturer"]);
                    Console.WriteLine("SerialNumber: {0}", queryObj["SerialNumber"]);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("A aparut o eroare in citirea placutelor ram!Cod eroare: " + e.Message);
            }
        }
    }
}
