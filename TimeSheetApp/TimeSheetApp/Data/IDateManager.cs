using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeSheetApp.Data
{
    public interface IDateManager
    {
        DateTimePickerFormat DateFormatType();
        string DateFormat();
        IEnumerable<string> GetMonthData();
    }
}
