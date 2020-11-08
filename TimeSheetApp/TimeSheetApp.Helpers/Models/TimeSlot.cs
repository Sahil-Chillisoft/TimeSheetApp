using System;

namespace TimeSheetApp.Helpers.Models
{
    public class TimeSlot
    {
        public int TimeslotId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal HoursCaptured { get; set; }
    }
}
