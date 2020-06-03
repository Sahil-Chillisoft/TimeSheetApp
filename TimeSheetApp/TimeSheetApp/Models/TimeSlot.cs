using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
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
