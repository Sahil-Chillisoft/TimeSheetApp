using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeSheetApp.Helpers.Data
{
    public interface IDateManager
    {
        DateTimePickerFormat DateFormatType();
        string DateFormat();
        IEnumerable<string> GetMonthData();
    }
}
