using System;
using Ninject;
using Ninject.Modules;

namespace ScheduleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = ScheduleRegistration.NewKernel();
            ScheduleViewer sv = (ScheduleViewer)kernel.Get<IScheduleViewer>();
            Console.WriteLine(sv.RenderSchedule());

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}