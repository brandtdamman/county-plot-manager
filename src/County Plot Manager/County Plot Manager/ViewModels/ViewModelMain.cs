using PlotManager.UI.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlotManager.UI.ViewModels
{
	public class ViewModelMain : ViewModelBase
	{

		private bool CanDeleteEmail = true;
		RelayCommand commandDeleteEmail;
		public ICommand CommandDeleteEmail
		{
			get
			{
				if (commandDeleteEmail == null)
				{
					commandDeleteEmail = new RelayCommand(param => DeleteEmail(),
					param => CanDeleteEmail);
				}
				return commandDeleteEmail;
			}
		}

		private bool CanDeletePhone = true;
		RelayCommand commandDeletePhone;
		public ICommand CommandDeletePhone
		{
			get
			{
				if (commandDeletePhone == null)
				{
					commandDeletePhone = new RelayCommand(param => DeletePhone(),
					param => CanDeletePhone);
				}
				return commandDeletePhone;
			}
		}


		private void DeleteEmail()
		{

		}
		private void DeletePhone()
		{

		}

	}
}
