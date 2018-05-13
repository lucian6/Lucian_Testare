using System;
using System.Management;

namespace Lucian_Testare
{
    class NumePc
    {
        public static void Nume_Pc()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("Nume Pc: {0}", queryObj["Name"]);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("Eroare la citire nume din WMI object cu urmatorul code eroare: " + e.Message);
            }
        }
    }
}
