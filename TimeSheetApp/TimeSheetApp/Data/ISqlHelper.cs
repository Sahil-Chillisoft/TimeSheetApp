using System.Collections.Generic;
using TimeSheetApp.Models;

namespace TimeSheetApp.Data
{
    public interface ISqlHelper
    {
        List<UserTimeSlot> GetUsersTimeByMonthAndYear(string month, string year);
        List<ProjectTimeSlot> GetProjectTimeByMonthAndYear(string month, string year);
        List<User> GetUsers(string search);
        List<TimeSlotUserProject> GetTimeSlotsByUsernameAndMonth(string username, string month);
    }
}
