using System;
using System.ComponentModel;

namespace TimeSheetApp.Helpers.Models
{
    public class TimeSlotUserProject
    {
        [DisplayName("User Id")]
        public int UserId { get; set; }

        public string Username { get; set; }

        [DisplayName("TimeSlot Id")]
        public int TimeslotId { get; set; }
        
        [DisplayName("Project Id")]
        public int ProjectId { get; set; }

        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [DisplayName("Hours Captured")]
        public decimal HoursCaptured { get; set; }

        public DateTime Date { get; set; }
    }
}
