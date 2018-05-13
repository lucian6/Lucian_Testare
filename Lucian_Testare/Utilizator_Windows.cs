using System;
using System.Management;

namespace Lucian_Testare
{
    class Utilizator_Windows
    {
        public static void User_Windows()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("Name: {0}", queryObj["Name"]);
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("A aparut o eroare la citirea User windows cu urmatorul cod de eroare: " + e.Message);
            }
        }
    }
}
