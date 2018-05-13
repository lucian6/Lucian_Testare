using System;
using System.Diagnostics;

namespace Lucian_Testare
{
    class Utilizare_CPU
    {
        //de refacut codul....nu citeste bine da 0% ....plm
        public static void UtilizareCpu()
        {
            PerformanceCounter cpuCounter;
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            Console.WriteLine(cpuCounter.NextValue() + "%");
            Console.ReadLine();

            
        }
    }
}
