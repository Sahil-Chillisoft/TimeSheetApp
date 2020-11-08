using System.ComponentModel;

namespace TimeSheetApp.Helpers.Models
{
    public class UserTimeSlot
    {
        [DisplayName("User Id")]
        public int UserId { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Total Hours")]
        public decimal TotalHoursForMonth { get; set; }
    }
}
