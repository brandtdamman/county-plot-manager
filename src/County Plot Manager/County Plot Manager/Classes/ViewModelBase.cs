using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.UI.Classes
{
	public class ViewModelBase : INotifyPropertyChanged
	{




		public event PropertyChangedEventHandler PropertyChanged;

		public void NotifyPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if (handler != null)
			{
				var e = new PropertyChangedEventArgs(propertyName);
				handler(this, e);
			}
		}

		[Conditional("DEBUG")]
		[DebuggerStepThrough]
		public void VerifyPropertyName(string propertyName)
		{
			if (TypeDescriptor.GetProperties(this)[propertyName] == null)
			{
				string msg = "Invalid property name:  " + propertyName;
				throw new Exception(msg);
			}
		}


	}
}
