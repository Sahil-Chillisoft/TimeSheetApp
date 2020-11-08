using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TimeSheetApp.Helpers.Models;

namespace TimeSheetApp.Helpers.Data
{
    public class SqlHelper : ISqlHelper
    {
        private static readonly string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public List<UserTimeSlot> GetUsersTimeByMonthAndYear(string month, string year)
        {
            #region SQL
            var sql = @"select u.UserId, u.Username, 
                        sum(ts.HoursCaptured) as TotalHoursForMonth 
                        from Timeslots ts 
                        inner join Users u on ts.UserId = u.UserId
                        where DATENAME(MONTH, ts.Date) = @Month and 
                        DATEPART(YEAR, ts.Date) = @Year 
                        group by u.UserId, u.Username ";
            #endregion

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<UserTimeSlot>
            (
                sql,
                new
                {
                    Month = month, 
                    Year = year
                }
            ).ToList();
            return userTimeSlotList;
            #endregion
        }

        public List<ProjectTimeSlot> GetProjectTimeByMonthAndYear(string month, string year)
        {
            #region SQL
            var sql = @"select p.ProjectId, p.Name, 
                        sum(ts.HoursCaptured) as TotalHoursForMonth 
                        from Timeslots ts 
                        inner join Projects p on ts.ProjectId = p.ProjectId 
                        where DATENAME(MONTH, ts.Date) = @Month and 
                        DATEPART(YEAR, ts.Date) = @Year 
                        group by p.ProjectId, p.Name ";
            #endregion

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userTimeSlotList = connection.Query<ProjectTimeSlot>
            (
                sql,
                new
                {
                    Month = month, 
                    Year = year
                }
            ).ToList();

            return userTimeSlotList;
            #endregion
        }

        public List<User> GetUsers(string search)
        {
            #region Sql
            var sql = @"select * from Users 
                        where Username like @Search";
            #endregion

            #region SQLExecution
            using var connection = new SqlConnection(ConnectionString);
            var userList = connection.Query<User>
            (
                sql,
                new
                {
                    Search = $"%{search}%"
                }
            ).ToList();

            return userList;
            #endregion
        }

        public List<TimeSlotUserProject> GetTimeSlotsByUsernameAndMonth(string username, string month)
        {
            #region Sql
            var sql = @"select ts.UserId, FirstMatchingUser.Username, ts.TimeslotId,
                        ts.ProjectId, p.Name as ProjectName, ts.HoursCaptured, ts.Date 
                        from Timeslots ts 
                        inner join 
                        ( 
                            select top 1 UserId, Username 
                            from Users 
                            where Username like @Username 
                        ) as FirstMatchingUser on ts.UserId = FirstMatchingUser.UserId 
                        inner join Projects p on ts.ProjectId = p.ProjectId 
                        where DATENAME(MONTH, ts.Date) = @Month ";
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
