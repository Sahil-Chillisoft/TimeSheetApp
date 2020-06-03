using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
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
