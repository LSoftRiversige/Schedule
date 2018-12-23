namespace ScheduleSolution
{
    interface IScheduleViewer
    {
        string RenderSchedule();
        int RowCount { get; set; }
        int Shift { get; }
        char ShiftChar { get; set; }
    }
}