using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TimeSheetApp.Models;

namespace TimeSheetApp.Data
{
    public class SqlHelper
    {
        public static string ConnectionString = "Server=SAHIL;Database=Timesheets;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static List<UserTimeSlot> GetUsersTimeByMonthAndYear(string month, string year)
        {
            #region SQL
            var sql = "select u.UserId, u.Username, ";
            sql += "sum(ts.HoursCaptured) as TotalHoursForMonth ";
            sql += "from Timeslots ts ";
            sql += "inner join Users u on ts.UserId = u.UserId ";
            sql += "where DATENAME(MONTH, ts.Date) = @Month and ";
            sql += "DATEPART(YEAR, ts.Date) = @Year ";
            sql += "group by u.UserId, u.Username ";
            #endregion

            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<UserTimeSlot>
            (
                sql,
                new { Month = month, Year = year }
            ).ToList();

            return userTimeSlotList;
        }


        public static List<ProjectTimeSlot> GetProjectTimeByMonthAndYear(string month, string year)
        {
            #region SQL
            var sql = "select p.ProjectId, p.Name, ";
            sql += "sum(ts.HoursCaptured) as TotalHoursForMonth ";
            sql += "from Timeslots ts ";
            sql += "inner join Projects p on ts.ProjectId = p.ProjectId ";
            sql += "where DATENAME(MONTH, ts.Date) = @Month and ";
            sql += "DATEPART(YEAR, ts.Date) = @Year ";
            sql += "group by p.ProjectId, p.Name ";
            #endregion

            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<ProjectTimeSlot>
            (
                sql,
                new { Month = month, Year = year }
            ).ToList();

            return userTimeSlotList;
        }
    }
}
