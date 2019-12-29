using System.Collections.Generic;

namespace PlotManager.Model
{
  public class Section
  {
    public int ID { get; set; }
    public string SectionName { get; set; }
    public bool HasFlagPole { get; set; }
    public int RowNumber { get; set; }
    public int ColumnNumber { get; set; }
    public List<PlotGroup> PlotGroups { get; set; }

  }
}

