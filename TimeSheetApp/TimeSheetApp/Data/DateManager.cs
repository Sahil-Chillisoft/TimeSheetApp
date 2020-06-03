using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheetApp.Data
{
    public class DateManager
    {
        public static DateTimePickerFormat DateFormatType = DateTimePickerFormat.Custom;
        
        public static string DateFormat = @"yyyy";

        public static IEnumerable<string> LoadMonthData()
        {
            var montList = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            return montList;
        }
    }
}
