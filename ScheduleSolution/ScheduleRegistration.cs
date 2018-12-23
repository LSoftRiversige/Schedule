using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace ScheduleSolution
{
    class ScheduleRegistration: NinjectModule
    {
        private const int ScheduleRowCount = 10;
        private const int ShiftCount = 25;
        private const char ShiftChar = '.';
        private const string ScheduleLine = "Расписание движения чего-либо";

        public override void Load()
        {
            Bind<IScheduleManager>().To<ScheduleManager>()
                .WithConstructorArgument("value", ScheduleLine);

            Bind<IScheduleViewer>().To<ScheduleViewer>()
                .WithConstructorArgument("shift", ShiftCount)
                .WithPropertyValue("RowCount", ScheduleRowCount)
                .WithPropertyValue("ShiftChar", ShiftChar);
        }

        public static StandardKernel NewKernel()
        {
            NinjectModule registrations = new ScheduleRegistration();
            return new StandardKernel(registrations);
        }
    }
}