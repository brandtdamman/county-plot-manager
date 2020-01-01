using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PlotManager.UI.Classes.Converters
{
	public class BoolsToMarginConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType,
													object parameter, CultureInfo culture)
		{

			var plotGroupMargin = new Thickness(0);

			if ((values[0] == DependencyProperty.UnsetValue)
					|| (values[1] == DependencyProperty.UnsetValue))
			{
				return plotGroupMargin;
			}

			if ((values == null) || (values[0] == null) || (values[1] == null))
			{
				return plotGroupMargin;
			}
			//Bottom is index 0, Right is index 1.
			bool flagBottom = System.Convert.ToBoolean(values[0]);
			bool flagRight = System.Convert.ToBoolean(values[1]);

			if (flagBottom)
			{
				plotGroupMargin.Bottom = 25;
			}
			if (flagRight)
			{
				plotGroupMargin.Right = 30;
			}
			return plotGroupMargin;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}


	}
}
