using System;
using System.Management;

namespace Lucian_Testare
{
    class Startup
    {
        public static void Startup_Program()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_StartupCommand");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("Description: {0}", queryObj["Description"]);
                }
            }
            catch (ManagementException e)
            {
               Console.WriteLine("A aparut o eroare in citirea fisierelor din startup: " + e.Message);
            }
        }
    }
}
