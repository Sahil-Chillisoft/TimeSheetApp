using System.Configuration;
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
        public static string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

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

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<UserTimeSlot>
            (
                sql,
                new { Month = month, Year = year }
            ).ToList();
            return userTimeSlotList;
            #endregion
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

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<ProjectTimeSlot>
            (
                sql,
                new { Month = month, Year = year }
            ).ToList();

            return userTimeSlotList;
            #endregion
        }

        public static List<User> GetUsers(string search)
        {
            #region Sql
            var sql = "select * from Users ";
            sql += "where Username like @Search";
            #endregion

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userList = connection.Query<User>
            (
                sql,
                new { Search = $"%{search}%" }
            ).ToList();

            return userList;
            #endregion
        }

        public static List<TimeSlotUserProject> GetTimeSlotsByUsernameAndMonth(string username, string month)
        {
            #region Sql
            var sql = "select ts.UserId, FirstMatchingUser.Username, ts.TimeslotId, ";
            sql += "ts.ProjectId, p.Name as ProjectName, ts.HoursCaptured, ts.Date ";
            sql += "from Timeslots ts ";
            sql += "inner join ";
            sql += "( ";
            sql += "select top 1 UserId, Username ";
            sql += "from Users ";
            sql += "where Username like @Username ";
            sql += ") as FirstMatchingUser on ts.UserId = FirstMatchingUser.UserId ";
            sql += "inner join Projects p on ts.ProjectId = p.ProjectId ";
            sql += "where DATENAME(MONTH, ts.Date) = @Month ";
            #endregion

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<TimeSlotUserProject>
            (
                sql,
                new
                {
                    Username = $"{username}%",
                    Month = month
                }
            ).ToList();

            return userTimeSlotList;
            #endregion
        }
    }
}
