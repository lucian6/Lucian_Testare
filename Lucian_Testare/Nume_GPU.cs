using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Lucian_Testare
{
    class Nume_GPU
    {
        public static void NumePV()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_VideoController");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("Nume Placa video: {0}", queryObj["Description"]);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("A aparut o eroare in a citi numele placi video,cod eroare: " + e.Message);
            }
        }
    }
}
