using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PlotManager.UI.Classes.Converters
{
  public class IntToBoolConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      int inputVal = (int)value;
      if (inputVal == 1) return true;
      return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      bool inputVal = (bool)value;
      if (inputVal) return 1;
      return 0;
    }


  }
}
