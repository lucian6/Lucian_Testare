using System;
using System.Management;

namespace Lucian_Testare
{
    class WBuild_Version
    {
        public static void WVersion()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_WMISetting");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("BuildVersion: {0}", queryObj["BuildVersion"]);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("A aparut e eroare in citirea versiunii build de windows: " + e.Message);
            }
        }
    }
}
