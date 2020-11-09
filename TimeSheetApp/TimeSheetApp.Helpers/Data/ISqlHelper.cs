using System.Collections.Generic;
using TimeSheetApp.Helpers.Models;

namespace TimeSheetApp.Helpers.Data
{
    public interface ISqlHelper
    {
        bool TestDatabaseConnection();
        List<UserTimeSlot> GetUsersTimeByMonthAndYear(string month, string year);
        List<ProjectTimeSlot> GetProjectTimeByMonthAndYear(string month, string year);
        List<User> GetUsers(string search);
        List<TimeSlotUserProject> GetTimeSlotsByUsernameAndMonth(string username, string month);
    }
}
