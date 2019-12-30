using PlotManager.Model;
using PlotManager.UI.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.UI.ViewModels
{
	public class ViewModelPlot : ViewModelBase
	{


		private string iD;
		public string ID
		{
			get
			{
				return iD;
			}
			set
			{
				if (value != iD)
				{
					iD = value;
					NotifyPropertyChanged("ID");
				}
			}
		}


		private string shortId;
		public string ShortId
		{
			get
			{
				return shortId;
			}
			set
			{
				if (value != shortId)
				{
					shortId = value;
					NotifyPropertyChanged("ShortId");
				}
			}
		}


		private Owner owner;
		public Owner Owner
		{
			get
			{
				return owner;
			}
			set
			{
				if (value != owner)
				{
					owner = value;
					NotifyPropertyChanged("Owner");
				}
			}
		}


		private List<Tenant> tenants;
		public List<Tenant> Tenants
		{
			get
			{
				return tenants;
			}
			set
			{
				if (value != tenants)
				{
					tenants = value;
					NotifyPropertyChanged("Tenants");
				}
			}
		}



	}
}
