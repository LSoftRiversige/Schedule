using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ScheduleSolution
{
    class ScheduleViewer : IScheduleViewer
    {
        private const int defaultRowCount = 7;
        private const char defaultChar = '_';
        IScheduleManager _scheduleManager;
        private int _rowCount;
        private char _shiftChar;

        public ScheduleViewer(IScheduleManager scheduleManager, int shift)
        {
            _scheduleManager = scheduleManager;
            _rowCount = defaultRowCount;
            Shift = shift;
            _shiftChar = defaultChar;
        }

        public string RenderSchedule()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < RowCount; i++)
            {
                AppendLine(i, sb);
            }
            return sb.ToString();
        }

        private void AppendLine(int i, StringBuilder sb)
        {
            sb.Append((i + 1).ToString().PadLeft(3));
            sb.Append(GetShiftString());
            sb.Append("<");
            sb.Append(_scheduleManager.GetSchedule());
            sb.Append(">");
            sb.AppendLine();
        }

        private string GetShiftString()
        {
            return ShiftChar.ToString().PadRight(Shift, ShiftChar);
        }

        public int RowCount { get => _rowCount; set => _rowCount = value; }
        public int Shift { get; private set; }
        public char ShiftChar { get => _shiftChar; set => _shiftChar = value; }
    }
}
