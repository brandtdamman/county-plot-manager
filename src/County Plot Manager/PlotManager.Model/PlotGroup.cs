using System.Collections.Generic;

namespace PlotManager.Model
{
	public class PlotGroup
	{
		public int ID { get; set; }
		public int RowNumber { get; set; }
		public int ColumnNumber { get; set; }
		public bool HasBottomMargin { get; set; }
		public bool HasRightMargin { get; set; }
		public List<Plot> Plots { get; set; }


	}
}
