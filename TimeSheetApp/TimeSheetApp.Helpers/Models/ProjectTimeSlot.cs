using System.ComponentModel;

namespace TimeSheetApp.Helpers.Models
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
