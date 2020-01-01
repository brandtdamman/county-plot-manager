using PlotManager.Model;
using PlotManager.UI.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.UI.ViewModels
{
	public class ViewModelPlotGroup : ViewModelBase
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

		private int rowNumber = 0;
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

		private int columnNumber = 0;
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

		private bool hasBottomMargin = false;
		public bool HasBottomMargin
		{
			get
			{
				return hasBottomMargin;
			}
			set
			{
				if (value != hasBottomMargin)
				{
					hasBottomMargin = value;
					NotifyPropertyChanged("HasBottomMargin");
				}
			}
		}

		private bool hasRightMargin = false;
		public bool HasRightMargin
		{
			get
			{
				return hasRightMargin;
			}
			set
			{
				if (value != hasRightMargin)
				{
					hasRightMargin = value;
					NotifyPropertyChanged("HasRightMargin");
				}
			}
		}

		private List<Plot> plots;
		public List<Plot> Plots
		{
			get
			{
				return plots;
			}
			set
			{
				if (value != plots)
				{
					plots = value;
					NotifyPropertyChanged("Plots");
				}
			}
		}



	}
}
