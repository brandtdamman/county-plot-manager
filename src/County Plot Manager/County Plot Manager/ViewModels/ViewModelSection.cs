using PlotManager.Model;
using PlotManager.UI.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.UI.ViewModels
{
	public class ViewModelSection : ViewModelBase
	{


		private int iD;
		public int ID
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

		private string sectionName;
		public string SectionName
		{
			get
			{
				return sectionName;
			}
			set
			{
				if (value != sectionName)
				{
					sectionName = value;
					NotifyPropertyChanged("SectionName");
				}
			}
		}

		private bool hasFlagPole;
		public bool HasFlagPole
		{
			get
			{
				return hasFlagPole;
			}
			set
			{
				if (value != hasFlagPole)
				{
					hasFlagPole = value;
					NotifyPropertyChanged("HasFlagPole");
				}
			}
		}

		private int rowNumber;
		public int RowNumber
		{
			get
			{
				return rowNumber;
			}
			set
			{
				if (value != rowNumber)
				{
					rowNumber = value;
					NotifyPropertyChanged("RowNumber");
				}
			}
		}

		private int columnNumber;
		public int ColumnNumber
		{
			get
			{
				return columnNumber;
			}
			set
			{
				if (value != columnNumber)
				{
					columnNumber = value;
					NotifyPropertyChanged("ColumnNumber");
				}
			}
		}

		private List<PlotGroup> plotGroupColumns;
		public List<PlotGroup> PlotGroupColumns
		{
			get
			{
				return plotGroupColumns;
			}
			set
			{
				if (value != plotGroupColumns)
				{
					plotGroupColumns = value;
					NotifyPropertyChanged("PlotGroupColumns");
				}
			}
		}



	}
}
