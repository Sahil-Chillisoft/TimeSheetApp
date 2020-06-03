using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class ProjectTimeSlot
    {
        [DisplayName("Project Id")]
        public int ProjectId { get; set; }
        [DisplayName("Project Name")]
        public string Name { get; set; }
        [DisplayName("Total Hours")]
        public decimal TotalHoursForMonth { get; set; }
    }
}
