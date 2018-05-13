using System;
using System.Management;

namespace Lucian_Testare
{
    class Versiune_Driver_Video
    {
        public static void VersiuneDriver()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("Versiune Driver: {0}", queryObj["DriverVersion"]);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("A aparut o eroare la citirea versiunii driverului video " + e.Message);
            }
        }
    }
}
