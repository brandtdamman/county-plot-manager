using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PlotManager.UI.Classes.Converters
{
	public class IntToFontSizeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType,
													object parameter, CultureInfo culture)
		{
			int numberOfItems = (int)value;
			if (numberOfItems > 1)
			{
				return 8;
			}
			else
			{
				return 12;
			}
		}

		public object ConvertBack(object value, Type targetType,
															object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}



	}
}
