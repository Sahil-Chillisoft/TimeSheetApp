using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TimeSheetApp.Helpers.Data
{
    public class DateManager : IDateManager
    {
        public DateTimePickerFormat DateFormatType()
        {
            return DateTimePickerFormat.Custom;
        }

        public string DateFormat()
        {
            return @"yyyy";
        }

        public IEnumerable<string> GetMonthData()
        {
            return CultureInfo.InvariantCulture.DateTimeFormat
                .MonthNames.Take(12).ToList();
        }
    }
}
