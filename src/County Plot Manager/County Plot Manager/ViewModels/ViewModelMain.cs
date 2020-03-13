using PlotManager.Model;
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

		private List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
		public List<PhoneNumber> PhoneNumbers
		{
			get
			{
				return phoneNumbers;
			}
			set
			{
				if (value != phoneNumbers)
				{
					phoneNumbers = value;
					NotifyPropertyChanged("PhoneNumbers");
				}
			}
		}

		private List<Email> emails;
		public List<Email> Emails
		{
			get
			{
				return emails;
			}
			set
			{
				if (value != emails)
				{
					emails = value;
					NotifyPropertyChanged("Emails");
				}
			}
		}

		private PhoneNumber phone;
		public PhoneNumber Phone
		{
			get
			{
				return phone;
			}
			set
			{
				if (value != phone)
				{
					phone = value;
					NotifyPropertyChanged("Phone");
				}
			}
		}

		private Email email;
		public Email Email
		{
			get
			{
				return email;
			}
			set
			{
				if (value != email)
				{
					email = value;
					NotifyPropertyChanged("Email");
				}
			}
		}

		private bool CanAddPhone = true;
		RelayCommand commandAddPhone;
		public ICommand CommandAddPhone
		{
			get
			{
				if (commandAddPhone == null)
				{
					commandAddPhone = new RelayCommand(param => AddPhone(),
					param => CanAddPhone);
				}
				return commandAddPhone;
			}
		}

		private bool CanDeletePhone = true;
		RelayCommand<object> commandDeletePhone;
		public ICommand CommandDeletePhone
		{
			get
			{
				if (commandDeletePhone == null)
				{
					commandDeletePhone = new RelayCommand<object>
					(param => DeletePhone(param),
					param => CanDeletePhone);
				}
				return commandDeletePhone;
			}
		}


		private void AddPhone()
		{
			List<PhoneNumber> lst = PhoneNumbers;
			lst.Add(new PhoneNumber());
			PhoneNumbers = lst;
		}

		private void DeletePhone(object parameter)
		{
			PhoneNumbers.Remove((PhoneNumber)parameter);
		}



	}
}
