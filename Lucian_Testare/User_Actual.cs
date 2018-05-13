using System;
using System.Management;

namespace Lucian_Testare
{
    class User_Actual
    {
        public static void UserActual()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("User logat: {0}", queryObj["UserName"]);
                }
            }
            catch (ManagementException e)
            {
                Console.Write("A aparut o eroare in a citi userul din wmi cu urmatorul code de eroare: " + e.Message);
            }

        }
    }
}
